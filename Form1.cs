﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClosedXML.Excel;
using System.Xml;
using System.Xml.Linq;
using System.Threading;
using System.Diagnostics;
using System.Globalization;

namespace rajadas
{
    public partial class Form1 : Form
    {
        private String caminhoArquivoDeConfiguracao = "Parametros.xml";

        private String caminhoArquivoTxtRajadaTijolo;
        private String caminhoRajadaProcessadaTijolo;
        private String parametroCopiarOuMoverRajadaTijolo;
        private String parametroIntervaloRajadaTijolo;
        private String parametroFrequenciaRajadaTijolo;
        private String statusLeituraRajadaTijolo;
        private String statusMonitoramentoRajadaTijolo;
        private String destinatariosRajadaTijolo;

        private String caminhoArquivoTxtRajadaDigital;
        private String caminhoRajadaProcessadaDigital;
        private String parametroCopiarOuMoverRajadaDigital;
        private String parametroIntervaloRajadaDigital;
        private String parametroFrequenciaRajadaDigital;
        private String statusLeituraRajadaDigital;
        private String statusMonitoramentoRajadaDigital;
        private String destinatariosRajadaDigital;

        private String caminhoArquivoTxtRajadaInvertida;
        private String caminhoRajadaProcessadaInvertida;
        private String parametroCopiarOuMoverRajadaInvertida;
        private String parametroIntervaloRajadaInvertida;
        private String parametroFrequenciaRajadaInvertida;
        private String statusLeituraRajadaInvertida;
        private String statusMonitoramentoRajadaInvertida;
        private String destinatariosRajadaInvertida;

        private String enderecoBD;
        private String portaBD;
        private String usuarioBD;
        private String senhaBD;
        private String nomeBD;

        private List<Monitoramento> listaMonitoramentoTijolo;
        private List<Monitoramento> listaMonitoramentoDigital;
        private List<Monitoramento> listaMonitoramentoInvertida;

        private DiaMonitoramento listaDiaMonitoramentoTijolo;
        private DiaMonitoramento listaDiaMonitoramentoDigital;
        private DiaMonitoramento listaDiaMonitoramentoInvertida;

        private string diretorioOrigemCSV;
        private string diretorioDestinoCSV;
        private string parametroIntervaloLeituraCSV;
        private string parametroFrequenciaLeituraCSV;
        private string statusLeituraCSV;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarParametrosBD();
            carregaParametrosRajadaTijolo();
            carregaParametrosRajadaDigital();
            carregaParemetrosRajadaInvertida();
            carregaObjetosMonitoramento();
            CarregarParametrosDetalhadoRegistro();
            expurgoArquivosAntigos();
        }

        protected void expurgoArquivosAntigos()
        {
            Rajada rajada = new Rajada();
            rajada.ExcluirArquivosProcessadosAntigos(this.caminhoRajadaProcessadaTijolo);
            rajada.ExcluirArquivosProcessadosAntigos(this.caminhoRajadaProcessadaDigital);
            rajada.ExcluirArquivosProcessadosAntigos(this.caminhoRajadaProcessadaInvertida);

            Expurgo expurgo = new Expurgo();
            expurgo.ExcluirArquivosCSVAntigos(this.diretorioDestinoCSV);
        }

        protected void monitoramentoTijolo()
        {
            carregaObjetosMonitoramento();

            List<string> listaDeArquivosEncontrados = new List<string>();

            Rajada rajada = new Rajada();

            // ** Pega o dia da semana ** //
            Agendamento agendamento = new Agendamento();
            string diaDaSemana = agendamento.retornarDiaDaSemana();

            // ** Verifica se no dia da semana atual será realizado o monitoramento ** //
            foreach (var dia in this.listaDiaMonitoramentoTijolo.diaMonitoramento)
            {
                if (dia == diaDaSemana)
                {
                    foreach (Monitoramento monitoramento in this.listaMonitoramentoTijolo)
                    {
                        // ** Pega o horário atual formatado como HH:MM ** //
                        String horaFormatada = agendamento.RetornarHorarioAtualFormatado();

                        // ** Verifica se a horário atual está na lista de monitoramento ** //
                        if (horaFormatada == monitoramento.horarioMonitoramento)
                        {
                            listaDeArquivosEncontrados = rajada.retornaQuantidadeArquivosEncontrados(this.caminhoArquivoTxtRajadaTijolo, "ARQBRSAGORD");
                            if (listaDeArquivosEncontrados.Count < Convert.ToInt32(monitoramento.qtdArquivos))
                            {
                                String arquivosEncontrados = "";

                                foreach (String arquivo in listaDeArquivosEncontrados)
                                {
                                    arquivosEncontrados = arquivosEncontrados + " \n " + arquivo;
                                }
                                // ** Adiciona o total de arquivos encontrados ao fim da lista que irá no corpo do e-mail ** //
                                arquivosEncontrados = arquivosEncontrados + " \n \n \n " + "Total de Arquivos:  " + listaDeArquivosEncontrados.Count();

                                // ** Envia e-mail aos destinatários parametrizando comunicando que algum arquivo não foi enviado ** //
                                Email email = new Email();
                                email.enviarEmail(this.destinatariosRajadaTijolo, "Monitoramento RAJADA TIJOLO - " + horaFormatada, "Estava prevista a recepção de " + monitoramento.qtdArquivos +
                                    " arquivo(s), porém foram localizados " + listaDeArquivosEncontrados.Count + " arquivo(s) na pasta de origem." + "\n \n " + "Segue(m) arquivo(s) localizado(s): " + "\n \n" + arquivosEncontrados);

                                // ** Atualiza a data de processamento do objeto monitoramento para evitar duplicidades ** //
                                BancoDeDados bancoDeDados = new BancoDeDados();
                                bancoDeDados.atualizaDataMonitoramentoExecutado(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, monitoramento, "1");

                                // ** Atualiza a tabela de MONITORAMENTO subtraindo 1 da quantidade arquivos em cada horário para evitar notificações desnecessárias ** //
                                BancoDeDados bd = new BancoDeDados();
                                bd.AtualizarTabelaDeMonitoramentoAposNotificarPorEmail(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "1");

                                // ** Atualiza os objetos de monitoramento
                                carregaObjetosMonitoramento();
                            }
                            else
                            {
                                // ** Atualiza a data de processamento do objeto monitoramento para evitar duplicidades ** //
                                BancoDeDados bancoDeDados = new BancoDeDados();
                                bancoDeDados.atualizaDataMonitoramentoExecutado(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, monitoramento, "1");
                            }
                        }
                    }
                }
            }
        }

        protected void monitoramentoDigital()
        {
            carregaObjetosMonitoramento();

            List<string> listaDeArquivosEncontrados = new List<string>();

            Rajada rajada = new Rajada();

            // ** Pega o dia da semana ** //
            Agendamento agendamento = new Agendamento();
            string diaDaSemana = agendamento.retornarDiaDaSemana();

            // ** Verifica se no dia da semana atual será realizado o monitoramento ** //
            foreach (var dia in this.listaDiaMonitoramentoDigital.diaMonitoramento)
            {
                if (dia == diaDaSemana)
                {
                    foreach (Monitoramento monitoramento in this.listaMonitoramentoDigital)
                    {
                        // ** Pega o horário atual formatado como HH:MM ** //
                        String horaFormatada = agendamento.RetornarHorarioAtualFormatado();

                        if (horaFormatada == monitoramento.horarioMonitoramento)
                        {
                            listaDeArquivosEncontrados = rajada.retornaQuantidadeArquivosEncontrados(this.caminhoArquivoTxtRajadaDigital, "BRSCANDIGIT");
                            if (listaDeArquivosEncontrados.Count < Convert.ToInt32(monitoramento.qtdArquivos))
                            {
                                String arquivosEncontrados = "";

                                foreach (String arquivo in listaDeArquivosEncontrados)
                                {
                                    arquivosEncontrados = arquivosEncontrados + " \n " + arquivo;
                                }
                                // ** Adiciona o total de arquivos encontrados ao fim da lista que irá no corpo do e-mail ** //
                                arquivosEncontrados = arquivosEncontrados + " \n \n \n " + "Total de Arquivos:  " + listaDeArquivosEncontrados.Count();

                                // ** Envia e-mail aos destinatários parametrizando comunicando que algum arquivo não foi enviado ** //
                                Email email = new Email();
                                email.enviarEmail(this.destinatariosRajadaDigital, "Monitoramento RAJADA DIGITAL (MUNDO VELHO) - " + horaFormatada, "Estava prevista a recepção de " + monitoramento.qtdArquivos +
                                    " arquivo(s), porém foram localizados " + listaDeArquivosEncontrados.Count + " arquivo(s) na pasta de origem." + "\n \n " + "Segue(m) arquivo(s) localizado(s): " + "\n \n" + arquivosEncontrados);

                                // ** Atualizada a data de processamento do objeto monitoramento para evitar duplicidades ** //
                                BancoDeDados bancoDeDados = new BancoDeDados();
                                bancoDeDados.atualizaDataMonitoramentoExecutado(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, monitoramento, "2");

                                // ** Atualiza a tabela de MONITORAMENTO subtraindo 1 da quantidade arquivos em cada horário para evitar notificações desnecessárias ** //
                                BancoDeDados bd = new BancoDeDados();
                                bd.AtualizarTabelaDeMonitoramentoAposNotificarPorEmail(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "2");

                                // ** Atualiza os objetos de monitoramento
                                carregaObjetosMonitoramento();
                            }
                            else
                            {
                                // ** Atualiza a data de processamento do objeto monitoramento para evitar duplicidades ** //
                                BancoDeDados bancoDeDados = new BancoDeDados();
                                bancoDeDados.atualizaDataMonitoramentoExecutado(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, monitoramento, "2");
                            }
                        }
                    }
                }
            }
        }

        protected void monitoramentoInvertida()
        {
            carregaObjetosMonitoramento();

            List<string> listaDeArquivosEncontrados = new List<string>();

            Rajada rajada = new Rajada();

            // ** Pega o dia da semana ** //
            Agendamento agendamento = new Agendamento();
            string diaDaSemana = agendamento.retornarDiaDaSemana();

            // ** Verifica se no dia da semana atual será realizado o monitoramento ** //
            foreach (var dia in this.listaDiaMonitoramentoInvertida.diaMonitoramento)
            {
                if (dia == diaDaSemana)
                {
                    foreach (Monitoramento monitoramento in this.listaMonitoramentoInvertida)
                    {
                        // ** Pega o horário atual formatado como HH:MM ** //
                        String horaFormatada = agendamento.RetornarHorarioAtualFormatado();

                        if (horaFormatada == monitoramento.horarioMonitoramento)
                        {
                            listaDeArquivosEncontrados = rajada.retornaQuantidadeArquivosEncontrados(this.caminhoArquivoTxtRajadaInvertida, "ARQBRSINVER");
                            if (listaDeArquivosEncontrados.Count < Convert.ToInt32(monitoramento.qtdArquivos))
                            {
                                String arquivosEncontrados = "";

                                foreach (String arquivo in listaDeArquivosEncontrados)
                                {
                                    arquivosEncontrados = arquivosEncontrados + " \n " + arquivo;
                                }
                                // ** Adiciona o total de arquivos encontrados ao fim da lista que irá no corpo do e-mail ** //
                                arquivosEncontrados = arquivosEncontrados + " \n \n \n " + "Total de Arquivos:  " + listaDeArquivosEncontrados.Count();

                                // ** Envia e-mail aos destinatários parametrizando comunicando que algum arquivo não foi enviado ** //
                                Email email = new Email();
                                email.enviarEmail(this.destinatariosRajadaInvertida, "Monitoramento RAJADA INVERTIDA - " + horaFormatada, "Estava prevista a recepção de " + monitoramento.qtdArquivos +
                                    " arquivo(s), porém foram localizados " + listaDeArquivosEncontrados.Count + " arquivo(s) na pasta de origem." + "\n \n " + "Segue(m) arquivo(s) localizado(s): " + "\n \n" + arquivosEncontrados);

                                // ** Atualizada a data de processamento do objeto monitoramento para evitar duplicidades ** //
                                BancoDeDados bancoDeDados = new BancoDeDados();
                                bancoDeDados.atualizaDataMonitoramentoExecutado(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, monitoramento, "3");

                                // ** Atualiza a tabela de MONITORAMENTO subtraindo 1 da quantidade arquivos em cada horário para evitar notificações desnecessárias ** //
                                BancoDeDados bd = new BancoDeDados();
                                bd.AtualizarTabelaDeMonitoramentoAposNotificarPorEmail(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "3");

                                // ** Atualiza os objetos de monitoramento
                                carregaObjetosMonitoramento();
                            }
                            else
                            {
                                // ** Atualiza a data de processamento do objeto monitoramento para evitar duplicidades ** //
                                BancoDeDados bancoDeDados = new BancoDeDados();
                                bancoDeDados.atualizaDataMonitoramentoExecutado(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, monitoramento, "3");
                            }
                        }
                    }
                }
            }

        }

        protected void carregaObjetosMonitoramento()
        {
            BancoDeDados bancoDeDados = new BancoDeDados();

            // ** Carrega os objetos de monitoramento do banco ** //
            this.listaMonitoramentoTijolo = bancoDeDados.listaMonitoramento(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "1");
            this.listaMonitoramentoDigital = bancoDeDados.listaMonitoramento(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "2");
            this.listaMonitoramentoInvertida = bancoDeDados.listaMonitoramento(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "3");

            // ** Carrega os dias dos monitoramentos do banco ** //
            this.listaDiaMonitoramentoTijolo = bancoDeDados.listarDiasDeMonitoramento(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "1");
            this.listaDiaMonitoramentoDigital = bancoDeDados.listarDiasDeMonitoramento(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "2");
            this.listaDiaMonitoramentoInvertida = bancoDeDados.listarDiasDeMonitoramento(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "3");
        }

        protected void carregarParametrosBD()
        {
            ParametrosSistema parametrosBD = new ParametrosSistema();
            List<String> listaDeParametrosBD = new List<String>();

            listaDeParametrosBD = parametrosBD.carregarParametrosBD(this.caminhoArquivoDeConfiguracao);

            this.enderecoBD = listaDeParametrosBD[0];
            this.portaBD = listaDeParametrosBD[1];
            this.usuarioBD = listaDeParametrosBD[2];
            this.senhaBD = listaDeParametrosBD[3];
            this.nomeBD = listaDeParametrosBD[4];
        }

        protected void carregaParametrosRajadaTijolo()
        {
            Agendamento agendamento = new Agendamento();

            BancoDeDados bancoDeDados = new BancoDeDados();

            // ---------------------------------- Carrega parâmetros da Rajada Tijolo -------------------------------------------------------//
            List<String> listaDeParametrosRajadaTijolo = new List<String>();

            listaDeParametrosRajadaTijolo = bancoDeDados.carregarParametrosRajadas(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "1");

            this.caminhoArquivoTxtRajadaTijolo = listaDeParametrosRajadaTijolo[1];
            this.caminhoRajadaProcessadaTijolo = listaDeParametrosRajadaTijolo[2];
            this.parametroCopiarOuMoverRajadaTijolo = listaDeParametrosRajadaTijolo[3];
            this.parametroIntervaloRajadaTijolo = listaDeParametrosRajadaTijolo[4];
            this.parametroFrequenciaRajadaTijolo = listaDeParametrosRajadaTijolo[5];
            this.statusLeituraRajadaTijolo = listaDeParametrosRajadaTijolo[6];
            this.statusMonitoramentoRajadaTijolo = listaDeParametrosRajadaTijolo[7];
            this.destinatariosRajadaTijolo = listaDeParametrosRajadaTijolo[8];

            tbCaminhoRajadaTijolo.Text = caminhoArquivoTxtRajadaTijolo;
            tbCaminhoRajadaProcessadaTijolo.Text = caminhoRajadaProcessadaTijolo;
            tbIntervaloRajadaTijolo.Text = parametroIntervaloRajadaTijolo;
            cbFrequenciaRajadaTijolo.SelectedItem = parametroFrequenciaRajadaTijolo;
            cbStatusLeituraTijolo.SelectedItem = statusLeituraRajadaTijolo;
            cbStatusMonitoramentoTijolo.SelectedItem = statusMonitoramentoRajadaTijolo;
            tbDestinatariosTijolo.Text = destinatariosRajadaTijolo;


            if (parametroCopiarOuMoverRajadaTijolo == "Copiar Arquivo Processado")
            {
                rbCopiarArquivoProcessadoRajadaTijolo.Checked = true;
            }
            else
            {
                rbMoverArquivoProcessadoRajadaTijolo.Checked = true;
            }
            // ---------------------------------- Carrega parâmetros da Rajada Tijolo ---------------------------------------------------------//


            // ---------------------------------- ** Seta os agendamentos das leituras no timer da Rajada Tijolo ** --------------------------------//
            tmRajadaTijolo.Interval = agendamento.retornaAgendamentoExecucao(parametroIntervaloRajadaTijolo, parametroFrequenciaRajadaTijolo);
            // ---------------------------------- ** Seta os agendamentos das leituras no timer da Rajada Tijolo ** --------------------------------//


            // ------------------ ** Ativa ou Desativa os Timers das leituras automáticas de acordo com o parâmetro ** --------------------//
            if (this.statusLeituraRajadaTijolo == "Ativada")
            {
                tmRajadaTijolo.Enabled = true;
            }
            else
            {
                tmRajadaTijolo.Enabled = false;
            }
            if (this.statusMonitoramentoRajadaTijolo == "Ativado")
            {
                tmMonitoramentoTijolo.Enabled = true;
            }
            else
            {
                tmMonitoramentoTijolo.Enabled = false;
            }
            // ------------------ ** Ativa ou Desativa os Timers das leituras automáticas de acordo com o parâmetro ** --------------------//


            // ------------------ ** Ativa ou Desativa os Parâmetros das Leituras Automáticas de acordo com o parâmetro ** -----------------------------//
            if (this.statusLeituraRajadaTijolo == "Ativada")
            {
                tbIntervaloRajadaTijolo.Enabled = true;
                cbFrequenciaRajadaTijolo.Enabled = true;
            }
            else
            {
                tbIntervaloRajadaTijolo.Enabled = false;
                cbFrequenciaRajadaTijolo.Enabled = false;
            }
            if (this.statusMonitoramentoRajadaTijolo == "Ativado")
            {
                btAgendamentoTijolo.Enabled = true;
                tbDestinatariosTijolo.Enabled = true;
            }
            else
            {
                btAgendamentoTijolo.Enabled = false;
                tbDestinatariosTijolo.Enabled = false;
            }
            // ------------------ ** Ativa ou Desativa os Parâmetros das Leituras Automáticas de acordo com o parâmetro ** -----------------------------//

        }
        // ---------------------------------- Carrega parâmetros da Rajada Tijolo ---------------------------------------------------------//


        // ---------------------------------- Carrega parâmetros da Rajada Digital ---------------------------------------------------------//
        protected void carregaParametrosRajadaDigital()
        {
            Agendamento agendamento = new Agendamento();

            BancoDeDados bancoDeDados = new BancoDeDados();

            List<String> listaDeParametrosRajadaDigital = new List<String>();

            listaDeParametrosRajadaDigital = bancoDeDados.carregarParametrosRajadas(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "2");

            this.caminhoArquivoTxtRajadaDigital = listaDeParametrosRajadaDigital[1];
            this.caminhoRajadaProcessadaDigital = listaDeParametrosRajadaDigital[2];
            this.parametroCopiarOuMoverRajadaDigital = listaDeParametrosRajadaDigital[3];
            this.parametroIntervaloRajadaDigital = listaDeParametrosRajadaDigital[4];
            this.parametroFrequenciaRajadaDigital = listaDeParametrosRajadaDigital[5];
            this.statusLeituraRajadaDigital = listaDeParametrosRajadaDigital[6];
            this.statusMonitoramentoRajadaDigital = listaDeParametrosRajadaDigital[7];
            this.destinatariosRajadaDigital = listaDeParametrosRajadaDigital[8];

            tbCaminhoRajadaDigital.Text = caminhoArquivoTxtRajadaDigital;
            tbCaminhoRajadaProcessadaDigital.Text = caminhoRajadaProcessadaDigital;
            tbIntervaloRajadaDigital.Text = parametroIntervaloRajadaDigital;
            cbFrequenciaRajadaDigital.SelectedItem = parametroFrequenciaRajadaDigital;
            cbStatusLeituraDigital.SelectedItem = statusLeituraRajadaDigital;
            cbStatusMonitoramentoDigital.SelectedItem = statusMonitoramentoRajadaDigital;
            tbDestinatariosDigital.Text = destinatariosRajadaDigital;

            if (parametroCopiarOuMoverRajadaDigital == "Copiar Arquivo Processado")
            {
                rbCopiarArquivoProcessadoRajadaDigital.Checked = true;
            }
            else
            {
                rbMoverArquivoProcessadoRajadaDigital.Checked = true;
            }

            // ---------------------------------- ** Seta os agendamentos das leituras no timer da Rajada Digital ** --------------------------------//
            tmRajadaDigital.Interval = agendamento.retornaAgendamentoExecucao(parametroIntervaloRajadaDigital, parametroFrequenciaRajadaDigital);
            // ---------------------------------- ** Seta os agendamentos das leituras no timer Digital ** --------------------------------//


            // ------------------ ** Ativa ou Desativa os Timers das leituras automáticas de acordo com o parâmetro ** --------------------//
            if (this.statusLeituraRajadaDigital == "Ativada")
            {
                tmRajadaDigital.Enabled = true;
            }
            else
            {
                tmRajadaDigital.Enabled = false;
            }
            if (this.statusMonitoramentoRajadaDigital == "Ativado")
            {
                tmMonitoramentoDigital.Enabled = true;
            }
            else
            {
                tmMonitoramentoDigital.Enabled = false;
            }
            // ------------------ ** Ativa ou Desativa os Timers das leituras automáticas de acordo com o parâmetro ** --------------------//


            // ------------------ ** Ativa ou Desativa os Parâmetros das Leituras Automáticas de acordo com o parâmetro ** -----------------------------//
            if (this.statusLeituraRajadaDigital == "Ativada")
            {
                tbIntervaloRajadaDigital.Enabled = true;
                cbFrequenciaRajadaDigital.Enabled = true;
            }
            else
            {
                tbIntervaloRajadaDigital.Enabled = false;
                cbFrequenciaRajadaDigital.Enabled = false;
            }
            if (this.statusMonitoramentoRajadaDigital == "Ativado")
            {
                btAgendamentoDigital.Enabled = true;
                tbDestinatariosDigital.Enabled = true;
            }
            else
            {
                btAgendamentoDigital.Enabled = false;
                tbDestinatariosDigital.Enabled = false;
            }
            // ------------------ ** Ativa ou Desativa os Parâmetros das Leituras Automáticas de acordo com o parâmetro ** -----------------------------//

        }
        // ---------------------------------- Carrega parâmetros da Rajada Digital --------------------------------------------------------//


        // ---------------------------------- Carrega parâmetros da Rajada Invertida --------------------------------------------------//
        protected void carregaParemetrosRajadaInvertida()
        {
            Agendamento agendamento = new Agendamento();

            BancoDeDados bancoDeDados = new BancoDeDados();

            List<String> listaDeParametrosRajadaInvertida = new List<String>();

            listaDeParametrosRajadaInvertida = bancoDeDados.carregarParametrosRajadas(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "3");

            this.caminhoArquivoTxtRajadaInvertida = listaDeParametrosRajadaInvertida[1];
            this.caminhoRajadaProcessadaInvertida = listaDeParametrosRajadaInvertida[2];
            this.parametroCopiarOuMoverRajadaInvertida = listaDeParametrosRajadaInvertida[3];
            this.parametroIntervaloRajadaInvertida = listaDeParametrosRajadaInvertida[4];
            this.parametroFrequenciaRajadaInvertida = listaDeParametrosRajadaInvertida[5];
            this.statusLeituraRajadaInvertida = listaDeParametrosRajadaInvertida[6];
            this.statusMonitoramentoRajadaInvertida = listaDeParametrosRajadaInvertida[7];
            this.destinatariosRajadaInvertida = listaDeParametrosRajadaInvertida[8];

            tbCaminhoRajadaInvertida.Text = caminhoArquivoTxtRajadaInvertida;
            tbCaminhoRajadaProcessadaInvertida.Text = caminhoRajadaProcessadaInvertida;
            tbIntervaloRajadaInvertida.Text = parametroIntervaloRajadaInvertida;
            cbFrequenciaRajadaInvertida.SelectedItem = parametroFrequenciaRajadaInvertida;
            cbStatusLeituraInvertida.SelectedItem = statusLeituraRajadaInvertida;
            cbStatusMonitoramentoInvertida.SelectedItem = statusMonitoramentoRajadaInvertida;
            tbDestinatariosInvertida.Text = destinatariosRajadaInvertida;

            if (parametroCopiarOuMoverRajadaInvertida == "Copiar Arquivo Processado")
            {
                rbCopiarArquivoProcessadoRajadaInvertida.Checked = true;
            }
            else
            {
                rbMoverArquivoProcessadoRajadaInvertida.Checked = true;
            }

            // ---------------------------------- ** Seta os agendamentos das leituras no timerda Rajada Invertida ** --------------------------------//
            tmRajadaInvertida.Interval = agendamento.retornaAgendamentoExecucao(parametroIntervaloRajadaInvertida, parametroFrequenciaRajadaInvertida);
            // ---------------------------------- ** Seta os agendamentos das leituras no timer da Rajada Invertida ** --------------------------------//


            // ------------------ ** Ativa ou Desativa os Timers das leituras automáticas de acordo com o parâmetro ** --------------------//
            if (this.statusLeituraRajadaInvertida == "Ativada")
            {
                tmRajadaInvertida.Enabled = true;
            }
            else
            {
                tmRajadaInvertida.Enabled = false;
            }
            if (this.statusMonitoramentoRajadaInvertida == "Ativado")
            {
                tmMonitoramentoInvertida.Enabled = true;
            }
            else
            {
                tmMonitoramentoInvertida.Enabled = false;
            }
            // ------------------ ** Ativa ou Desativa os Timers das leituras automáticas de acordo com o parâmetro ** --------------------//



            // ------------------ ** Ativa ou Desativa os Parâmetros das Leituras Automáticas de acordo com o parâmetro ** -----------------------------//
            if (this.statusLeituraRajadaInvertida == "Ativada")
            {
                tbIntervaloRajadaInvertida.Enabled = true;
                cbFrequenciaRajadaInvertida.Enabled = true;
            }
            else
            {
                tbIntervaloRajadaInvertida.Enabled = false;
                cbFrequenciaRajadaInvertida.Enabled = false;
            }
            if (this.statusMonitoramentoRajadaInvertida == "Ativado")
            {
                btAgendamentoInvertida.Enabled = true;
                tbDestinatariosInvertida.Enabled = true;
            }
            else
            {
                btAgendamentoInvertida.Enabled = false;
                tbDestinatariosInvertida.Enabled = false;
            }
            // ------------------ ** Ativa ou Desativa os Parâmetros das Leituras Automáticas de acordo com o parâmetro ** -----------------------------//

        }
        // ---------------------------------- Carrega parâmetros da Rajada Invertida ----------------------------------------------------//

        // ---------------------------------- Carrega parâmetros da leitura do CSV Detalhado de Registro --------------------------------------------------//
        protected void CarregarParametrosDetalhadoRegistro()
        {
            Agendamento agendamento = new Agendamento();

            BancoDeDados bancoDeDados = new BancoDeDados();

            List<String> listaDeParametrosDetalhadoRegistro = new List<String>();

            listaDeParametrosDetalhadoRegistro = bancoDeDados.CarregarParametrosLeituraDetalhadoRegistro(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD);

            if (listaDeParametrosDetalhadoRegistro.Count == 5)
            {
                this.diretorioOrigemCSV = listaDeParametrosDetalhadoRegistro[0];
                this.diretorioDestinoCSV = listaDeParametrosDetalhadoRegistro[1];
                this.statusLeituraCSV = listaDeParametrosDetalhadoRegistro[2];
                this.parametroIntervaloLeituraCSV = listaDeParametrosDetalhadoRegistro[3];
                this.parametroFrequenciaLeituraCSV = listaDeParametrosDetalhadoRegistro[4];

                tbOrigemCSV.Text = this.diretorioOrigemCSV;
                tbDestinoCSV.Text = this.diretorioDestinoCSV;
                cbStatusLeituraDR.SelectedItem = this.statusLeituraCSV;
                tbIntervaloLeituraDR.Text = this.parametroIntervaloLeituraCSV;
                cbFrequenciaLeituraDR.SelectedItem = this.parametroFrequenciaLeituraCSV;

                // ---------------------------------- ** Seta os agendamentos das leituras no timerda Rajada Invertida ** --------------------------------//
                tmLeituraCSVDetalhadoRegistro.Interval = agendamento.retornaAgendamentoExecucao(parametroIntervaloLeituraCSV, parametroFrequenciaLeituraCSV);
                // ---------------------------------- ** Seta os agendamentos das leituras no timer da Rajada Invertida ** --------------------------------//


                // ------------------ ** Ativa ou Desativa os Timers das leituras automáticas de acordo com o parâmetro ** --------------------//
                if (this.statusLeituraCSV == "Ativada")
                {
                    tmLeituraCSVDetalhadoRegistro.Enabled = true;
                }
                else
                {
                    tmLeituraCSVDetalhadoRegistro.Enabled = false;
                }
                // ------------------ ** Ativa ou Desativa os Timers das leituras automáticas de acordo com o parâmetro ** --------------------//



                // ------------------ ** Ativa ou Desativa os Parâmetros das Leituras Automáticas de acordo com o parâmetro ** -----------------------------//
                if (this.statusLeituraCSV == "Ativada")
                {
                    tbIntervaloLeituraDR.Enabled = true;
                    cbFrequenciaLeituraDR.Enabled = true;
                }
                else
                {
                    tbIntervaloLeituraDR.Enabled = false;
                    cbFrequenciaLeituraDR.Enabled = false;
                }
            }

            
            // ------------------ ** Ativa ou Desativa os Parâmetros das Leituras Automáticas de acordo com o parâmetro ** -----------------------------//

        }
        // ---------------------------------- Carrega parâmetros da leitura do CSV Detalhado de Registro ----------------------------------------------------//

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }


        private void botaoApontaCaminhoRajada_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog abrirArquivoRajada = new FolderBrowserDialog();
            if (abrirArquivoRajada.ShowDialog() == DialogResult.OK)
            {
                this.caminhoArquivoTxtRajadaTijolo = abrirArquivoRajada.SelectedPath;
                tbCaminhoRajadaTijolo.Text = this.caminhoArquivoTxtRajadaTijolo;
            }
        }

        private void botaoApontaArquivoExcel_Click(object sender, EventArgs e)
        {
            
        }

        private void btCaminhoRajadaProcessada_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog abrirDiretorioRajadaProcessada = new FolderBrowserDialog();
            if (abrirDiretorioRajadaProcessada.ShowDialog() == DialogResult.OK)
            {
                caminhoRajadaProcessadaTijolo = abrirDiretorioRajadaProcessada.SelectedPath;
                tbCaminhoRajadaProcessadaTijolo.Text = caminhoRajadaProcessadaTijolo;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void apontaCaminhoRajada_HelpRequest(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btSalvarConfiguracoes_Click(object sender, EventArgs e)
        {

        }

        private void btApontaArquivoExcelRajadaTijolo_Click(object sender, EventArgs e)
        {
        }

        private void rbCopiarArquivoProcessadoRajadaTijolo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMoverArquivoProcessadoRajadaTijolo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btCaminhoRajadaDigital_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog abrirArquivoRajada = new FolderBrowserDialog();
            if (abrirArquivoRajada.ShowDialog() == DialogResult.OK)
            {
                this.caminhoArquivoTxtRajadaDigital = abrirArquivoRajada.SelectedPath;
                tbCaminhoRajadaDigital.Text = this.caminhoArquivoTxtRajadaDigital;
            }
        }

        private void btCaminhoArquivoExcelRajadaDigital_Click(object sender, EventArgs e)
        {
           
        }

        private void btCaminhoArquivoExcelRajadaTrintaTrinta_Click(object sender, EventArgs e)
        {
            
        }

        private void btApontaCaminhoRajadaTrintaTrinta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog abrirArquivoRajada = new FolderBrowserDialog();
            if (abrirArquivoRajada.ShowDialog() == DialogResult.OK)
            {
                this.caminhoArquivoTxtRajadaInvertida = abrirArquivoRajada.SelectedPath;
                tbCaminhoRajadaInvertida.Text = this.caminhoArquivoTxtRajadaInvertida;
            }
        }

        private void btCaminhoRajadaProcessadaDigital_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog abrirDiretorioRajadaProcessada = new FolderBrowserDialog();
            if (abrirDiretorioRajadaProcessada.ShowDialog() == DialogResult.OK)
            {
                caminhoRajadaProcessadaDigital = abrirDiretorioRajadaProcessada.SelectedPath;
                tbCaminhoRajadaProcessadaDigital.Text = caminhoRajadaProcessadaDigital;
            }
        }

        private void btCaminhoRajadaProcessadaTrintaTrinta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog abrirDiretorioRajadaProcessada = new FolderBrowserDialog();
            if (abrirDiretorioRajadaProcessada.ShowDialog() == DialogResult.OK)
            {
                caminhoRajadaProcessadaInvertida = abrirDiretorioRajadaProcessada.SelectedPath;
                tbCaminhoRajadaProcessadaInvertida.Text = caminhoRajadaProcessadaInvertida;
            }
        }

        private void tmRajadaTijolo_Tick(object sender, EventArgs e)
        {
            try
            {
                btLerArquivoTijolo.Visible = false;

                pbLeituraTijolo.Visible = true;

                Rajada rajada = new Rajada();
                
                List<Rajada> listaDeObjetosRajada = new List<Rajada>();

                BancoDeDados bancoDeDados = new BancoDeDados();

                // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//
                listaDeObjetosRajada = rajada.lerArquivoTxtRajadaTijolo(caminhoArquivoTxtRajadaTijolo, caminhoRajadaProcessadaTijolo, parametroCopiarOuMoverRajadaTijolo);

                pbLeituraTijolo.Maximum = listaDeObjetosRajada.Count();

                // ** Insere a rajada sumarizada no banco ** //
                bancoDeDados.insereRajadaSumarizada(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeObjetosRajada, "1");

                for (int i = 0; i < listaDeObjetosRajada.Count(); i++)
                {
                    bancoDeDados.insereRajadaNoBD(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeObjetosRajada[i], "1");
                    pbLeituraTijolo.Value = i;
                }
                // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//

                pbLeituraTijolo.Visible = false;
                btLerArquivoTijolo.Visible = true; 
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar realizar a leitura da Rajada Tijolo!");
                Application.Exit();
            }
        }

        private void tmRajadaDigital_Tick(object sender, EventArgs e)
        {
            try
            {
                btLerArquivoDigital.Visible = false;

                pbLeituraDigital.Visible = true;

                Rajada rajada = new Rajada();

                List<Rajada> listaDeObjetosRajada = new List<Rajada>();

                BancoDeDados bancoDeDados = new BancoDeDados();

                // ------------------------** Lê Rajada Digital Mundo Velho e Insere no Excel ** -----------------------------//
                listaDeObjetosRajada = rajada.lerArquivoTxtRajadaDigital(caminhoArquivoTxtRajadaDigital, caminhoRajadaProcessadaDigital, parametroCopiarOuMoverRajadaDigital);

                pbLeituraDigital.Maximum = listaDeObjetosRajada.Count();

                // ** Insere a rajada sumarizada no banco ** //
                bancoDeDados.insereRajadaSumarizada(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeObjetosRajada, "2");

                for (int i = 0; i < listaDeObjetosRajada.Count(); i++)
                {
                    bancoDeDados.insereRajadaNoBD("this.enderecoBD", this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeObjetosRajada[i], "2");
                    pbLeituraDigital.Value = i;
                }
                // ------------------------** Lê Rajada Digital Mundo Velho e Insere no Excel ** -----------------------------//

                pbLeituraDigital.Visible = false;
                btLerArquivoDigital.Visible = true;
                
                // ------------------------** Lê Rajada Digital Mundo Velho e Insere no Excel ** -----------------------------//
            }
            catch (Exception)
            {
                MessageBox.Show("O Arquivo 'Parametros.xml' não foi localizado na pasta do sistema, o sistema será encerrado !");
                Application.Exit();
            }
        }

        private void tmRajadaInvertida_Tick(object sender, EventArgs e)
        {
            try
            {
                btLerArquivoInvertida.Visible = false;

                pbLeituraInvertida.Visible = true;

                Rajada rajada = new Rajada();

                List<Rajada> listaDeObjetosRajada = new List<Rajada>();

                BancoDeDados bancoDeDados = new BancoDeDados();

                // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//
                listaDeObjetosRajada = rajada.lerArquivoTxtRajadaInvertida(caminhoArquivoTxtRajadaInvertida, caminhoRajadaProcessadaInvertida, parametroCopiarOuMoverRajadaInvertida);

                pbLeituraInvertida.Maximum = listaDeObjetosRajada.Count();

                // ** Insere a rajada sumarizada no banco ** //
                bancoDeDados.insereRajadaSumarizada(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeObjetosRajada, "3");

                for (int i = 0; i < listaDeObjetosRajada.Count(); i++)
                {
                    bancoDeDados.insereRajadaNoBD(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeObjetosRajada[i], "3");
                    pbLeituraInvertida.Value = i;
                }
                // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//

                pbLeituraInvertida.Visible = false;
                btLerArquivoInvertida.Visible = true;
                
                // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//
            }

            catch (Exception)
            {
                MessageBox.Show("O Arquivo 'Parametros.xml' não foi localizado na pasta do sistema, o sistema será encerrado !");
                Application.Exit();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();

                niBandeja.Visible = true;
            }
        }

        private void niBandeja_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;

            niBandeja.Visible = false;
        }

        // -------------------------- ** Bloqueia digitação de caracteres diferentes de números inteiros ** -----------------------//
        private void tbIntervaloRajadaTijolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbIntervaloRajadaDigital_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbIntervaloRajadaInvertida_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIntervaloRajadaInvertida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // -------------------------- ** Bloqueia digitação de caracteres diferentes de números inteiros ** -----------------------//

        private void btSalvarArquivoTijolo_Click(object sender, EventArgs e)
        {
            // ----- ** Validação dos campos Intervalo para não permitir a digitação de zero ou em branco ** -------- //
            if (tbIntervaloRajadaTijolo.Text.Equals("") || tbIntervaloRajadaTijolo.Text.Equals("0") || tbDestinatariosTijolo.Text.Equals(""))
            {
                MessageBox.Show("Não são permitidos campos em branco ou iguais a zero !!!");
            }
            else
            {

                List<String> listaDeParametrosParaSalvar = new List<String>();

                this.parametroIntervaloRajadaTijolo = tbIntervaloRajadaTijolo.Text;
                this.parametroFrequenciaRajadaTijolo = cbFrequenciaRajadaTijolo.SelectedItem.ToString();
                this.statusLeituraRajadaTijolo = cbStatusLeituraTijolo.SelectedItem.ToString();

                if (rbCopiarArquivoProcessadoRajadaTijolo.Checked)
                {
                    parametroCopiarOuMoverRajadaTijolo = rbCopiarArquivoProcessadoRajadaTijolo.Text;
                }
                else
                {
                    parametroCopiarOuMoverRajadaTijolo = rbMoverArquivoProcessadoRajadaTijolo.Text;
                }

                this.statusMonitoramentoRajadaTijolo = cbStatusMonitoramentoTijolo.SelectedItem.ToString();
                this.destinatariosRajadaTijolo = tbDestinatariosTijolo.Text.Trim();

                listaDeParametrosParaSalvar.Add(this.caminhoArquivoTxtRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.caminhoRajadaProcessadaTijolo);
                listaDeParametrosParaSalvar.Add(this.parametroCopiarOuMoverRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.parametroIntervaloRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.parametroFrequenciaRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.statusLeituraRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.statusMonitoramentoRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.destinatariosRajadaTijolo);

                BancoDeDados bancoDeDados = new BancoDeDados();
                Boolean retorno = bancoDeDados.atualizaParametrosRajadas(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeParametrosParaSalvar, "1");

                if (retorno == true)
                {
                    MessageBox.Show("As configurações foram salvas !!!", "Mensagem do sistema");  
                }

                carregaParametrosRajadaTijolo();
            }
        }

        private void btSalvarArquivoDigital_Click(object sender, EventArgs e)
        {
            // ----- ** Validação dos campos Intervalo para não permitir a digitação de zero ou em branco ** -------- //
            if (tbIntervaloRajadaDigital.Text.Equals("") || tbIntervaloRajadaDigital.Text.Equals("0") || tbDestinatariosDigital.Text.Equals(""))
            {
                MessageBox.Show("Não são permitidos campos em branco ou iguais a zero !!!");
            }
            else
            {
                List<String> listaDeParametrosParaSalvar = new List<String>();

                this.parametroIntervaloRajadaDigital = tbIntervaloRajadaDigital.Text;
                this.parametroFrequenciaRajadaDigital = cbFrequenciaRajadaDigital.SelectedItem.ToString();
                this.statusLeituraRajadaDigital = cbStatusLeituraDigital.SelectedItem.ToString();

                if (rbCopiarArquivoProcessadoRajadaDigital.Checked)
                {
                    parametroCopiarOuMoverRajadaDigital = rbCopiarArquivoProcessadoRajadaDigital.Text;
                }
                else
                {
                    parametroCopiarOuMoverRajadaDigital = rbMoverArquivoProcessadoRajadaDigital.Text;
                }

                this.statusMonitoramentoRajadaDigital = cbStatusMonitoramentoDigital.SelectedItem.ToString();
                this.destinatariosRajadaDigital = tbDestinatariosDigital.Text.Trim();

                listaDeParametrosParaSalvar.Add(this.caminhoArquivoTxtRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.caminhoRajadaProcessadaDigital);
                listaDeParametrosParaSalvar.Add(this.parametroCopiarOuMoverRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.parametroIntervaloRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.parametroFrequenciaRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.statusLeituraRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.statusMonitoramentoRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.destinatariosRajadaDigital);

                BancoDeDados bancoDeDados = new BancoDeDados();
                Boolean retorno = bancoDeDados.atualizaParametrosRajadas(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeParametrosParaSalvar, "2");

                if (retorno == true)
                {
                    MessageBox.Show("As configurações foram salvas !!!", "Mensagem do sistema");                    
                }
                carregaParametrosRajadaDigital();
            }
        }

        private void btSalvarArquivoInvertida_Click(object sender, EventArgs e)
        {
            // ----- ** Validação dos campos Intervalo para não permitir a digitação de zero ou em branco ** -------- //
            if (tbIntervaloRajadaInvertida.Text.Equals("") || tbIntervaloRajadaInvertida.Text.Equals("0") || tbDestinatariosInvertida.Text.Equals(""))
            {
                MessageBox.Show("Não são permitidos campos em branco ou iguais a zero !!!");
            }
            else
            {
                List<String> listaDeParametrosParaSalvar = new List<String>();

                this.parametroIntervaloRajadaInvertida = tbIntervaloRajadaInvertida.Text;
                this.parametroFrequenciaRajadaInvertida = cbFrequenciaRajadaInvertida.SelectedItem.ToString();
                this.statusLeituraRajadaInvertida = cbStatusLeituraInvertida.SelectedItem.ToString();

                if (rbCopiarArquivoProcessadoRajadaInvertida.Checked)
                {
                    parametroCopiarOuMoverRajadaInvertida = rbCopiarArquivoProcessadoRajadaInvertida.Text;
                }
                else
                {
                    parametroCopiarOuMoverRajadaInvertida = rbMoverArquivoProcessadoRajadaInvertida.Text;
                }

                this.statusMonitoramentoRajadaInvertida = cbStatusMonitoramentoInvertida.SelectedItem.ToString();
                this.destinatariosRajadaInvertida = tbDestinatariosInvertida.Text.Trim();

                listaDeParametrosParaSalvar.Add(this.caminhoArquivoTxtRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.caminhoRajadaProcessadaInvertida);
                listaDeParametrosParaSalvar.Add(this.parametroCopiarOuMoverRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.parametroIntervaloRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.parametroFrequenciaRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.statusLeituraRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.statusMonitoramentoRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.destinatariosRajadaInvertida);

                BancoDeDados bancoDeDados = new BancoDeDados();
                Boolean retorno = bancoDeDados.atualizaParametrosRajadas(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeParametrosParaSalvar, "3");

                if (retorno == true)
                {
                    MessageBox.Show("As configurações foram salvas !!!", "Mensagem do sistema");
                }

                carregaParemetrosRajadaInvertida();
            }
        }

        private void btLerArquivoTijolo_Click(object sender, EventArgs e)
        {
                btLerArquivoTijolo.Visible = false;

                pbLeituraTijolo.Visible = true;

                Rajada rajada = new Rajada();

                List<Rajada> listaDeObjetosRajada = new List<Rajada>();

                BancoDeDados bancoDeDados = new BancoDeDados();

                // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//
                listaDeObjetosRajada = rajada.lerArquivoTxtRajadaTijolo(caminhoArquivoTxtRajadaTijolo, caminhoRajadaProcessadaTijolo, parametroCopiarOuMoverRajadaTijolo);

                pbLeituraTijolo.Maximum = listaDeObjetosRajada.Count();

                // ** Insere a rajada sumarizada no banco ** //
                bancoDeDados.insereRajadaSumarizada(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeObjetosRajada, "1");

                for (int i = 0; i < listaDeObjetosRajada.Count(); i++)
                {
                    bancoDeDados.insereRajadaNoBD(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeObjetosRajada[i], "1");
                    pbLeituraTijolo.Value = i;
                }
                // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//

                pbLeituraTijolo.Visible = false;
                btLerArquivoTijolo.Visible = true;

                // -------------------------** Mensagem ao fim da leitura manual -----------------------------------//
                MessageBox.Show("Processamento Concluído !!!" + "\n" + "Total de Contas Processadas: " + listaDeObjetosRajada.Count(), "Mensagem do sistema");
        }

        private void btLerArquivoDigital_Click(object sender, EventArgs e)
        {
            btLerArquivoDigital.Visible = false;

            pbLeituraDigital.Visible = true;

            Rajada rajada = new Rajada();

            List<Rajada> listaDeObjetosRajada = new List<Rajada>();

            BancoDeDados bancoDeDados = new BancoDeDados();

            // ------------------------** Lê Rajada Digital Mundo Velho e Insere no Excel ** -----------------------------//
            listaDeObjetosRajada = rajada.lerArquivoTxtRajadaDigital(caminhoArquivoTxtRajadaDigital, caminhoRajadaProcessadaDigital, parametroCopiarOuMoverRajadaDigital);

            pbLeituraDigital.Maximum = listaDeObjetosRajada.Count();

            // ** Insere a rajada sumarizada no banco ** //
            bancoDeDados.insereRajadaSumarizada(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeObjetosRajada, "2");

            for (int i = 0; i < listaDeObjetosRajada.Count(); i++)
                {
                    bancoDeDados.insereRajadaNoBD(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeObjetosRajada[i], "2");
                    pbLeituraDigital.Value = i;
                }
                // ------------------------** Lê Rajada Digital Mundo Velho e Insere no Excel ** -----------------------------//

                pbLeituraDigital.Visible = false;
                btLerArquivoDigital.Visible = true;

                // -------------------------** Mensagem ao fim da leitura manual -----------------------------------//
                MessageBox.Show("Processamento Concluído !!!" + "\n" + "Total de Contas Processadas: " + listaDeObjetosRajada.Count(), "Mensagem do sistema");
        }

        private void btLerArquivoInvertida_Click(object sender, EventArgs e)
        {
            btLerArquivoInvertida.Visible = false;

            pbLeituraInvertida.Visible = true;

            Rajada rajada = new Rajada();

            List<Rajada> listaDeObjetosRajada = new List<Rajada>();

            BancoDeDados bancoDeDados = new BancoDeDados();

            // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//
            listaDeObjetosRajada = rajada.lerArquivoTxtRajadaInvertida(caminhoArquivoTxtRajadaInvertida, caminhoRajadaProcessadaInvertida, parametroCopiarOuMoverRajadaInvertida);

            pbLeituraInvertida.Maximum = listaDeObjetosRajada.Count();

            // ** Insere a rajada sumarizada no banco ** //
            bancoDeDados.insereRajadaSumarizada(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeObjetosRajada, "3");

            for (int i = 0; i < listaDeObjetosRajada.Count(); i++)
                {
                    bancoDeDados.insereRajadaNoBD(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeObjetosRajada[i], "3");
                    pbLeituraInvertida.Value = i;
                }
                // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//

                pbLeituraInvertida.Visible = false;
                btLerArquivoInvertida.Visible = true;

                // -------------------------** Mensagem ao fim da leitura manual -----------------------------------//
                MessageBox.Show("Processamento Concluído !!!" + "\n" + "Total de Contas Processadas: " + listaDeObjetosRajada.Count(), "Mensagem do sistema");
        }

        private void bwLerArquivoTijolo_DoWork(object sender, DoWorkEventArgs e)
        {}

        private void tmBarraProgressoTijolo_Tick(object sender, EventArgs e)
        {}

       
        private void tmMonitoramentoArquivosRajadaTijolo_Tick(object sender, EventArgs e)
        {}
      
        private void tmMonitoramentoArquivosRajadaDigital_Tick(object sender, EventArgs e)
        {}

        private void tmMonitoramentoArquivosRajadaInvertida_Tick(object sender, EventArgs e)
        {}

        private void btSalvarMonitoramentoTijolo_Click(object sender, EventArgs e)
        {}

        private void btSalvarMonitoramentoDigital_Click(object sender, EventArgs e)
        {}

        private void btSalvarMonitoramentoInvertida_Click(object sender, EventArgs e)
        {}

        private void btAgendamentoTijolo_Click(object sender, EventArgs e)
        {
            FormMonitoramento formMonitoramento = new FormMonitoramento();
            formMonitoramento.ParametroTipoRajada = "1";
            formMonitoramento.ParametroNomeRajada = "TIJOLO";
            formMonitoramento.Show();

            this.Hide();
        }

        private void btAgendamentoDigital_Click(object sender, EventArgs e)
        {
            FormMonitoramento formMonitoramento = new FormMonitoramento();
            formMonitoramento.ParametroTipoRajada = "2";
            formMonitoramento.ParametroNomeRajada = "DIGITAL";
            formMonitoramento.Show();

            this.Hide();
        }

        private void btAgendamentoInvertida_Click(object sender, EventArgs e)
        {
            FormMonitoramento formMonitoramento = new FormMonitoramento();
            formMonitoramento.ParametroTipoRajada = "3";
            formMonitoramento.ParametroNomeRajada = "INVERTIDA";
            formMonitoramento.Show();

            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tmMonitoramentoTijolo_Tick(object sender, EventArgs e)
        {
            monitoramentoTijolo();
        }

        private void tmMonitoramentoDigital_Tick(object sender, EventArgs e)
        {
            monitoramentoDigital();
        }

        private void tmMonitoramentoInvertida_Tick(object sender, EventArgs e)
        {
            monitoramentoInvertida();
        }

        private void tmRotinaExpurgo_Tick(object sender, EventArgs e)
        {
            expurgoArquivosAntigos();
        }

        private void tmRotinaRestauracaoMonitoramento_Tick(object sender, EventArgs e)
        {
            try
            {
                // ** Retorna o horário atual formatado como HH:MM ** //
                Agendamento agendamento = new Agendamento();
                string horaAtual = agendamento.RetornarHorarioAtualFormatado();

                // ** Verifica se é o horário retornardo é igual à 00:00. Em caso positivo restaura a tabela de MONITORAMENTO copiando os valores da tabela MONITORAMENTO TEMPORÁRIO ** //
                if (horaAtual == "16:30")
                {
                    BancoDeDados bancoDeDados = new BancoDeDados();
                    bancoDeDados.RestaurarTabelaDeMonitoramentoAtual(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "1");
                    bancoDeDados.RestaurarTabelaDeMonitoramentoAtual(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "2");
                    bancoDeDados.RestaurarTabelaDeMonitoramentoAtual(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, "3");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ** Faz a leitura manual dos arquivos .CSV ** //
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;

            pbLeituraDR.Visible = true;

            int contadorRegistrosImportados = 0;

            int contadorRegistrosAtualizados = 0;

            DetalhadoRegistro detalhadoRegistro = new DetalhadoRegistro();

            List<string> listaDeArquivosCSV = new List<string>();

            // ** Recupera os arquivos CSV encontrados no diretório especificado **//
            listaDeArquivosCSV = detalhadoRegistro.LocalizarArquivosCSV(this.diretorioOrigemCSV);

            foreach (var arquivoEncontrado in listaDeArquivosCSV)
            {
                pbLeituraDR.Value = 0;

                BancoDeDados bancoDeDados = new BancoDeDados();

                List<DetalhadoRegistro> listaDetalhadoRegistroBD = new List<DetalhadoRegistro>();

                listaDetalhadoRegistroBD = bancoDeDados.ListarDetalhadoRegistro(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD);

                List<DetalhadoRegistro> listaDetalhadoRegistroInserir = new List<DetalhadoRegistro>();

                listaDetalhadoRegistroInserir = detalhadoRegistro.LerArquivoDetalhadoDeRegistro(arquivoEncontrado);

                if (listaDetalhadoRegistroInserir != null)
                {

                    List<DetalhadoRegistro> listaDetalhadoRegistroNovos = detalhadoRegistro.CompararListasDetalhadoRegistroObjetosNovos(listaDetalhadoRegistroInserir, listaDetalhadoRegistroBD);

                    List<DetalhadoRegistro> listaDetalhadoRegistroAtualizar = detalhadoRegistro.CompararListasDetalhadoRegistroObjetosCadastrados(listaDetalhadoRegistroInserir, listaDetalhadoRegistroBD);

                    if (listaDetalhadoRegistroNovos != null)
                    {
                        contadorRegistrosImportados = contadorRegistrosImportados + listaDetalhadoRegistroNovos.Count();
                    }

                    if (listaDetalhadoRegistroAtualizar != null)
                    {
                        contadorRegistrosAtualizados = contadorRegistrosAtualizados + listaDetalhadoRegistroAtualizar.Count();
                    }

                    pbLeituraDR.Maximum = contadorRegistrosImportados + contadorRegistrosAtualizados;

                    if (listaDetalhadoRegistroAtualizar != null)
                    {
                        for (int i = 0; i < listaDetalhadoRegistroAtualizar.Count(); i++)
                        {
                            bancoDeDados.AtualizarDetalhadoDoRegistro(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDetalhadoRegistroAtualizar[i]);
                            pbLeituraDR.Value = i;
                        }
                    }

                    if (listaDetalhadoRegistroNovos != null)
                    {
                        for (int i = 0; i < listaDetalhadoRegistroNovos.Count(); i++)
                        {
                            bancoDeDados.InserirDetalhadoDoRegistro(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDetalhadoRegistroNovos[i], listaDetalhadoRegistroNovos[i].sistema);
                            pbLeituraDR.Value = i;
                        }
                    }

                    detalhadoRegistro.MoverArquivoProcessado(arquivoEncontrado, this.diretorioDestinoCSV);
                }

            }

            pbLeituraDR.Visible = false;
            button2.Visible = true;

            // -------------------------** Mensagem ao fim da leitura manual -----------------------------------//
            MessageBox.Show("Processamento Concluído !!!" + "\n" + "Total de Protocolos Importados: " + contadorRegistrosImportados + "\n" + "Total de Protocolos Atualizados: " + contadorRegistrosAtualizados, "Mensagem do sistema");

        }

        private void btnOrigemCSV_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog indicarOrigemCSV = new FolderBrowserDialog();
            if (indicarOrigemCSV.ShowDialog() == DialogResult.OK)
            {
                this.diretorioOrigemCSV = indicarOrigemCSV.SelectedPath;
                tbOrigemCSV.Text = this.diretorioOrigemCSV;
            }
        }

        private void btnDestinoCSV_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog indicarDestinoCSV = new FolderBrowserDialog();
            if (indicarDestinoCSV.ShowDialog() == DialogResult.OK)
            {
                this.diretorioDestinoCSV = indicarDestinoCSV.SelectedPath;
                tbDestinoCSV.Text = this.diretorioDestinoCSV;
            }
        }

        private void btnSalvarConfiguracoesDR_Click(object sender, EventArgs e)
        {
            // ----- ** Validação dos campos Intervalo para não permitir a digitação de zero ou em branco ** -------- //
            if (tbIntervaloLeituraDR.Text.Equals("") || tbIntervaloLeituraDR.Text.Equals("0"))
            {
                MessageBox.Show("Não são permitidos campos em branco ou iguais a zero !!!");
            }
            else
            {
                List<String> listaDeParametrosParaSalvar = new List<String>();

                this.statusLeituraCSV = cbStatusLeituraDR.SelectedItem.ToString();
                this.parametroIntervaloLeituraCSV = tbIntervaloLeituraDR.Text;
                this.parametroFrequenciaLeituraCSV = cbFrequenciaLeituraDR.SelectedItem.ToString();                
                
                listaDeParametrosParaSalvar.Add(this.diretorioOrigemCSV);
                listaDeParametrosParaSalvar.Add(this.diretorioDestinoCSV);
                listaDeParametrosParaSalvar.Add(this.statusLeituraCSV);
                listaDeParametrosParaSalvar.Add(this.parametroIntervaloLeituraCSV);
                listaDeParametrosParaSalvar.Add(this.parametroFrequenciaLeituraCSV);

                BancoDeDados bancoDeDados = new BancoDeDados();
                Boolean retorno = bancoDeDados.AtualizaParametrosLeituraDetalhadoRegistro(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDeParametrosParaSalvar);

                if (retorno == true)
                {
                    MessageBox.Show("As configurações foram salvas !!!", "Mensagem do sistema");
                }

                CarregarParametrosDetalhadoRegistro();
            }
        }

        // ** Timer que faz a leitura dos arquivos CSV do Detalhado de Registro de tempos em tempos ** //
        private void tmLeituraCSVDetalhadoRegistro_Tick(object sender, EventArgs e)
        {
            button2.Visible = false;

            pbLeituraDR.Visible = true;

            int contadorRegistrosImportados = 0;

            int contadorRegistrosAtualizados = 0;

            DetalhadoRegistro detalhadoRegistro = new DetalhadoRegistro();

            List<string> listaDeArquivosCSV = new List<string>();

            // ** Recupera os arquivos CSV encontrados no diretório especificado **//
            listaDeArquivosCSV = detalhadoRegistro.LocalizarArquivosCSV(this.diretorioOrigemCSV);

            foreach (var arquivoEncontrado in listaDeArquivosCSV)
            {
                pbLeituraDR.Value = 0;

                BancoDeDados bancoDeDados = new BancoDeDados();

                List<DetalhadoRegistro> listaDetalhadoRegistroBD = new List<DetalhadoRegistro>();

                listaDetalhadoRegistroBD = bancoDeDados.ListarDetalhadoRegistro(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD);

                List<DetalhadoRegistro> listaDetalhadoRegistroInserir = new List<DetalhadoRegistro>();

                listaDetalhadoRegistroInserir = detalhadoRegistro.LerArquivoDetalhadoDeRegistro(arquivoEncontrado);

                if (listaDetalhadoRegistroInserir != null)
                {

                    List<DetalhadoRegistro> listaDetalhadoRegistroNovos = detalhadoRegistro.CompararListasDetalhadoRegistroObjetosNovos(listaDetalhadoRegistroInserir, listaDetalhadoRegistroBD);

                    List<DetalhadoRegistro> listaDetalhadoRegistroAtualizar = detalhadoRegistro.CompararListasDetalhadoRegistroObjetosCadastrados(listaDetalhadoRegistroInserir, listaDetalhadoRegistroBD);

                    if (listaDetalhadoRegistroNovos != null)
                    {
                        contadorRegistrosImportados = contadorRegistrosImportados + listaDetalhadoRegistroNovos.Count();
                    }

                    if (listaDetalhadoRegistroAtualizar != null)
                    {
                        contadorRegistrosAtualizados = contadorRegistrosAtualizados + listaDetalhadoRegistroAtualizar.Count();
                    }

                    pbLeituraDR.Maximum = contadorRegistrosImportados + contadorRegistrosAtualizados;

                    if (listaDetalhadoRegistroAtualizar != null)
                    {
                        for (int i = 0; i < listaDetalhadoRegistroAtualizar.Count(); i++)
                        {
                            bancoDeDados.AtualizarDetalhadoDoRegistro(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDetalhadoRegistroAtualizar[i]);
                            pbLeituraDR.Value = i;
                        }
                    }

                    if (listaDetalhadoRegistroNovos != null)
                    {
                        for (int i = 0; i < listaDetalhadoRegistroNovos.Count(); i++)
                        {
                            bancoDeDados.InserirDetalhadoDoRegistro(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaDetalhadoRegistroNovos[i], listaDetalhadoRegistroNovos[i].sistema);
                            pbLeituraDR.Value = i;
                        }
                    }

                    detalhadoRegistro.MoverArquivoProcessado(arquivoEncontrado, this.diretorioDestinoCSV);
                }

            }

            pbLeituraDR.Visible = false;
            button2.Visible = true;

            //// -------------------------** Mensagem ao fim da leitura manual -----------------------------------//
            //MessageBox.Show("Processamento Concluído !!!" + "\n" + "Total de Protocolos Importados: " + contadorRegistrosImportados + "\n" + "Total de Protocolos Atualizados: " + contadorRegistrosAtualizados, "Mensagem do sistema");

        }
    }
}
