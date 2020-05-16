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


namespace rajadas
{
    public partial class Form1 : Form
    {
        private String caminhoArquivoDeConfiguracao = "Parametros.xml";

        private String caminhoArquivoTxtRajadaTijolo;
        private String caminhoArquivoExcelRajadaTijolo;
        private String caminhoRajadaProcessadaTijolo;
        private String parametroCopiarOuMoverRajadaTijolo;
        private String parametroIntervaloRajadaTijolo;
        private String parametroFrequenciaRajadaTijolo;
        private String statusLeituraRajadaTijolo;
        private String parametroIntervaloMonitoramentoRajadaTijolo;
        private String parametroFrequenciaMonitoramentoRajadaTijolo;
        private String statusMonitoramentoRajadaTijolo;
        private String destinatariosRajadaTijolo;

        private String caminhoArquivoTxtRajadaDigital;
        private String caminhoArquivoExcelRajadaDigital;
        private String caminhoRajadaProcessadaDigital;
        private String parametroCopiarOuMoverRajadaDigital;
        private String parametroIntervaloRajadaDigital;
        private String parametroFrequenciaRajadaDigital;
        private String statusLeituraRajadaDigital;
        private String parametroIntervaloMonitoramentoRajadaDigital;
        private String parametroFrequenciaMonitoramentoRajadaDigital;
        private String statusMonitoramentoRajadaDigital;
        private String destinatariosRajadaDigital;

        private String caminhoArquivoTxtRajadaInvertida;
        private String caminhoArquivoExcelRajadaInvertida;
        private String caminhoRajadaProcessadaInvertida;
        private String parametroCopiarOuMoverRajadaInvertida;
        private String parametroIntervaloRajadaInvertida;
        private String parametroFrequenciaRajadaInvertida;
        private String statusLeituraRajadaInvertida;
        private String parametroIntervaloMonitoramentoRajadaInvertida;
        private String parametroFrequenciaMonitoramentoRajadaInvertida;
        private String statusMonitoramentoRajadaInvertida;
        private String destinatariosRajadaInvertida;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregaParametrosRajadaTijolo();
            carregaParametrosRajadaDigital();
            carregaParemetrosRajadaInvertida();
        }


        protected void carregaParametrosRajadaTijolo()
        {
            Agendamento agendamento = new Agendamento();

            ParametrosSistema parametrosRajada = new ParametrosSistema();

            // ---------------------------------- Carrega parâmetros da Rajada Tijolo -------------------------------------------------------//
            List<String> listaDeParametrosRajadaTijolo = new List<String>();

            listaDeParametrosRajadaTijolo = parametrosRajada.carregarParametrosRajada(this.caminhoArquivoDeConfiguracao, "Tijolo");

            this.caminhoArquivoTxtRajadaTijolo = listaDeParametrosRajadaTijolo[0];
            this.caminhoRajadaProcessadaTijolo = listaDeParametrosRajadaTijolo[1];
            this.parametroCopiarOuMoverRajadaTijolo = listaDeParametrosRajadaTijolo[2];
            this.parametroIntervaloRajadaTijolo = listaDeParametrosRajadaTijolo[3];
            this.parametroFrequenciaRajadaTijolo = listaDeParametrosRajadaTijolo[4];
            this.statusLeituraRajadaTijolo = listaDeParametrosRajadaTijolo[5];
            this.statusMonitoramentoRajadaTijolo = listaDeParametrosRajadaTijolo[6];
            this.parametroIntervaloMonitoramentoRajadaTijolo = listaDeParametrosRajadaTijolo[7];
            this.parametroFrequenciaMonitoramentoRajadaTijolo = listaDeParametrosRajadaTijolo[8];
            this.destinatariosRajadaTijolo = listaDeParametrosRajadaTijolo[9];
            
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


            // ---------------------------------- ** Seta os agendamentos das leituras e monitoramento no timer da Rajada Tijolo ** --------------------------------//
            tmRajadaTijolo.Interval = agendamento.retornaAgendamentoExecucao(parametroIntervaloRajadaTijolo, parametroFrequenciaRajadaTijolo);
            tmMonitoramentoArquivosRajadaTijolo.Interval = agendamento.retornaAgendamentoExecucao(parametroIntervaloMonitoramentoRajadaTijolo, parametroFrequenciaMonitoramentoRajadaTijolo);
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
                tmMonitoramentoArquivosRajadaTijolo.Enabled = true;
            }
            else
            {
                tmMonitoramentoArquivosRajadaTijolo.Enabled = false;
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

            ParametrosSistema parametrosRajada = new ParametrosSistema();

            List<String> listaDeParametrosRajadaDigital = new List<String>();

            listaDeParametrosRajadaDigital = parametrosRajada.carregarParametrosRajada(this.caminhoArquivoDeConfiguracao, "Digital");

            this.caminhoArquivoTxtRajadaDigital = listaDeParametrosRajadaDigital[0];
            this.caminhoRajadaProcessadaDigital = listaDeParametrosRajadaDigital[1];
            this.parametroCopiarOuMoverRajadaDigital = listaDeParametrosRajadaDigital[2];
            this.parametroIntervaloRajadaDigital = listaDeParametrosRajadaDigital[3];
            this.parametroFrequenciaRajadaDigital = listaDeParametrosRajadaDigital[4];
            this.statusLeituraRajadaDigital = listaDeParametrosRajadaDigital[5];
            this.statusMonitoramentoRajadaDigital = listaDeParametrosRajadaDigital[6];
            this.parametroIntervaloMonitoramentoRajadaDigital = listaDeParametrosRajadaDigital[7];
            this.parametroFrequenciaMonitoramentoRajadaDigital = listaDeParametrosRajadaDigital[8];
            this.destinatariosRajadaDigital = listaDeParametrosRajadaDigital[9];

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
            tmMonitoramentoArquivosRajadaDigital.Interval = agendamento.retornaAgendamentoExecucao(parametroIntervaloMonitoramentoRajadaDigital, parametroFrequenciaMonitoramentoRajadaDigital);
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
                tmMonitoramentoArquivosRajadaDigital.Enabled = true;
            }
            else
            {
                tmMonitoramentoArquivosRajadaDigital.Enabled = false;
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

            ParametrosSistema parametrosRajada = new ParametrosSistema();

            List<String> listaDeParametrosRajadaInvertida = new List<String>();

            listaDeParametrosRajadaInvertida = parametrosRajada.carregarParametrosRajada(this.caminhoArquivoDeConfiguracao, "Invertida");

            this.caminhoArquivoTxtRajadaInvertida = listaDeParametrosRajadaInvertida[0];
            this.caminhoRajadaProcessadaInvertida = listaDeParametrosRajadaInvertida[1];
            this.parametroCopiarOuMoverRajadaInvertida = listaDeParametrosRajadaInvertida[2];
            this.parametroIntervaloRajadaInvertida = listaDeParametrosRajadaInvertida[3];
            this.parametroFrequenciaRajadaInvertida = listaDeParametrosRajadaInvertida[4];
            this.statusLeituraRajadaInvertida = listaDeParametrosRajadaInvertida[5];
            this.statusMonitoramentoRajadaInvertida = listaDeParametrosRajadaInvertida[6];
            this.parametroIntervaloMonitoramentoRajadaInvertida = listaDeParametrosRajadaInvertida[7];
            this.parametroFrequenciaMonitoramentoRajadaInvertida = listaDeParametrosRajadaInvertida[8];
            this.destinatariosRajadaInvertida = listaDeParametrosRajadaInvertida[9];

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
            tmMonitoramentoArquivosRajadaInvertida.Interval = agendamento.retornaAgendamentoExecucao(parametroIntervaloMonitoramentoRajadaInvertida, parametroFrequenciaMonitoramentoRajadaInvertida);
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
                tmMonitoramentoArquivosRajadaInvertida.Enabled = true;
            }
            else
            {
                tmMonitoramentoArquivosRajadaInvertida.Enabled = false;
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

                    for (int i = 0; i < listaDeObjetosRajada.Count(); i++)
                    {
                        bancoDeDados.insereRajadaNoBD("127.0.0.1", "3306", "root", "160310", "itau", listaDeObjetosRajada[i], "1");
                        pbLeituraTijolo.Value = i;
                    }
                    // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//

                    pbLeituraTijolo.Visible = false;
                    btLerArquivoTijolo.Visible = true;
                
            }

            catch (Exception)
            {
                MessageBox.Show("O Arquivo 'Parametros.xml' não foi localizado na pasta do sistema, o sistema será encerrado !");
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

                    for (int i = 0; i < listaDeObjetosRajada.Count(); i++)
                    {
                        bancoDeDados.insereRajadaNoBD("127.0.0.1", "3306", "root", "160310", "itau", listaDeObjetosRajada[i], "2");
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

                    for (int i = 0; i < listaDeObjetosRajada.Count(); i++)
                    {
                        bancoDeDados.insereRajadaNoBD("127.0.0.1", "3306", "root", "160310", "itau", listaDeObjetosRajada[i], "3");
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
                MessageBox.Show("Não é permitido campos em branco ou iguais a zero !!!");
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
                this.destinatariosRajadaTijolo = tbDestinatariosTijolo.Text;

                listaDeParametrosParaSalvar.Add(this.caminhoArquivoTxtRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.caminhoRajadaProcessadaTijolo);
                listaDeParametrosParaSalvar.Add(this.parametroCopiarOuMoverRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.parametroIntervaloRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.parametroFrequenciaRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.statusLeituraRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.statusMonitoramentoRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.destinatariosRajadaTijolo);

                //ParametrosSistema parametrosSistema = new ParametrosSistema();
                //parametrosSistema.salvarConfiguracoes(listaDeParametrosParaSalvar, this.caminhoArquivoDeConfiguracao, "Tijolo", 0, 9);
                BancoDeDados bancoDeDados = new BancoDeDados();
                Boolean retorno = bancoDeDados.insereParametrosDoSistemaNoBD("127.0.0.1", "3306", "root", "160310", "itau", listaDeParametrosParaSalvar, "1");

                if (retorno == true)
                {
                    MessageBox.Show("As configurações foram salvas !!!", "Mensagem do sistema");

                    carregaParametrosRajadaTijolo();
                }
                else
                {

                }
                
            }
        }

        private void btSalvarArquivoDigital_Click(object sender, EventArgs e)
        {
            // ----- ** Validação dos campos Intervalo para não permitir a digitação de zero ou em branco ** -------- //
            if (tbIntervaloRajadaDigital.Text.Equals("") || tbIntervaloRajadaDigital.Text.Equals("0") || tbDestinatariosDigital.Text.Equals(""))
            {
                MessageBox.Show("Não é permitido campos em branco ou iguais a zero !!!");
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
                this.destinatariosRajadaDigital = tbDestinatariosDigital.Text;

                listaDeParametrosParaSalvar.Add(this.caminhoArquivoTxtRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.caminhoRajadaProcessadaDigital);
                listaDeParametrosParaSalvar.Add(this.parametroCopiarOuMoverRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.parametroIntervaloRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.parametroFrequenciaRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.statusLeituraRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.statusMonitoramentoRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.destinatariosRajadaDigital);

                //ParametrosSistema parametrosSistema = new ParametrosSistema();
                //parametrosSistema.salvarConfiguracoes(listaDeParametrosParaSalvar, this.caminhoArquivoDeConfiguracao, "Digital", 0, 9);
                BancoDeDados bancoDeDados = new BancoDeDados();
                Boolean retorno = bancoDeDados.insereParametrosDoSistemaNoBD("127.0.0.1", "3306", "root", "160310", "itau", listaDeParametrosParaSalvar, "2");

                if (retorno == true)
                {
                    MessageBox.Show("As configurações foram salvas !!!", "Mensagem do sistema");

                    carregaParametrosRajadaTijolo();
                }
                else
                {

                }
            }
        }

        private void btSalvarArquivoInvertida_Click(object sender, EventArgs e)
        {
            // ----- ** Validação dos campos Intervalo para não permitir a digitação de zero ou em branco ** -------- //
            if (tbIntervaloRajadaInvertida.Text.Equals("") || tbIntervaloRajadaInvertida.Text.Equals("0") || tbDestinatariosInvertida.Text.Equals(""))
            {
                MessageBox.Show("Não é permitido campos em branco ou iguais a zero !!!");
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
                this.destinatariosRajadaInvertida = tbDestinatariosInvertida.Text;

                listaDeParametrosParaSalvar.Add(this.caminhoArquivoTxtRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.caminhoRajadaProcessadaInvertida);
                listaDeParametrosParaSalvar.Add(this.parametroCopiarOuMoverRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.parametroIntervaloRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.parametroFrequenciaRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.statusLeituraRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.statusMonitoramentoRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.destinatariosRajadaInvertida);

                //ParametrosSistema parametrosSistema = new ParametrosSistema();
                //parametrosSistema.salvarConfiguracoes(listaDeParametrosParaSalvar, this.caminhoArquivoDeConfiguracao, "Invertida", 0, 9);
                BancoDeDados bancoDeDados = new BancoDeDados();
                Boolean retorno = bancoDeDados.insereParametrosDoSistemaNoBD("127.0.0.1", "3306", "root", "160310", "itau", listaDeParametrosParaSalvar, "3");

                if (retorno == true)
                {
                    MessageBox.Show("As configurações foram salvas !!!", "Mensagem do sistema");

                    carregaParametrosRajadaTijolo();
                }
                else
                {

                }
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

                for (int i = 0; i < listaDeObjetosRajada.Count(); i++)
                {
                    bancoDeDados.insereRajadaNoBD("127.0.0.1", "3306", "root", "160310", "itau", listaDeObjetosRajada[i], "1");
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

                for (int i = 0; i < listaDeObjetosRajada.Count(); i++)
                {
                    bancoDeDados.insereRajadaNoBD("127.0.0.1", "3306", "root", "160310", "itau", listaDeObjetosRajada[i], "2");
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

                for (int i = 0; i < listaDeObjetosRajada.Count(); i++)
                {
                    bancoDeDados.insereRajadaNoBD("127.0.0.1", "3306", "root", "160310", "itau", listaDeObjetosRajada[i], "3");
                    pbLeituraInvertida.Value = i;
                }
                // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//

                pbLeituraInvertida.Visible = false;
                btLerArquivoInvertida.Visible = true;

                // -------------------------** Mensagem ao fim da leitura manual -----------------------------------//
                MessageBox.Show("Processamento Concluído !!!" + "\n" + "Total de Contas Processadas: " + listaDeObjetosRajada.Count(), "Mensagem do sistema");
        }

        private void bwLerArquivoTijolo_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }

        private void tmBarraProgressoTijolo_Tick(object sender, EventArgs e)
        {

        }

        // ** Timer que monitora os arquivos de Rajado do tipo Tijolo ** //
        private void tmMonitoramentoArquivosRajadaTijolo_Tick(object sender, EventArgs e)
        {
            Rajada rajada = new Rajada();

            List<String> listaDeArquivosEncontrados = new List<String>();
            listaDeArquivosEncontrados = rajada.retornaQuantidadeArquivosEncontrados(this.caminhoArquivoTxtRajadaTijolo, "ARQBRSAGORD");

            String arquivosEncontrados = "";

            foreach (String arquivo in listaDeArquivosEncontrados)
            {
                arquivosEncontrados =  arquivosEncontrados + " \n " + arquivo;
            }
            // ** Adiciona o total de arquivos encontrados ao fim da lista que irá no corpo do e-mail ** //
            arquivosEncontrados = arquivosEncontrados + " \n \n \n " + "Total de Arquivos:  " + listaDeArquivosEncontrados.Count();

            String horaAtual = DateTime.Now.ToString();

            Email email = new Email();
            email.enviarEmail(this.destinatariosRajadaTijolo, "Monitoramento de Rajadas Tijolo - " + horaAtual, "Arquivos lógicos RAJADA TIJOLO encontrados até " + horaAtual + " \n " + arquivosEncontrados);
        }
        // ** Timer que monitora os arquivos de Rajado do tipo Tijolo ** //


        // ** Timer que monitora os arquivos de Rajado do tipo Digital ** //
        private void tmMonitoramentoArquivosRajadaDigital_Tick(object sender, EventArgs e)
        {
            Rajada rajada = new Rajada();

            List<String> listaDeArquivosEncontrados = new List<String>();
            listaDeArquivosEncontrados = rajada.retornaQuantidadeArquivosEncontrados(this.caminhoArquivoTxtRajadaTijolo, "BRSCANDIGIT");

            String arquivosEncontrados = "";

            foreach (String arquivo in listaDeArquivosEncontrados)
            {
                arquivosEncontrados = arquivosEncontrados + " \n " + arquivo;
            }
            // ** Adiciona o total de arquivos encontrados ao fim da lista que irá no corpo do e-mail ** //
            arquivosEncontrados = arquivosEncontrados + " \n \n \n " + "Total de Arquivos:  " + listaDeArquivosEncontrados.Count();

            String horaAtual = DateTime.Now.ToString();

            Email email = new Email();
            email.enviarEmail(this.destinatariosRajadaDigital, "Monitoramento de Rajadas Digitais (Mundo Velho) - " + horaAtual, "Arquivos lógicos RAJADA DIGITAL (MUNDO VELHO) encontrados até " + horaAtual + " \n " + arquivosEncontrados);
        }
        // ** Timer que monitora os arquivos de Rajado do tipo Digital ** //


        // ** Timer que monitora os arquivos de Rajado do tipo Invertida ** //
        private void tmMonitoramentoArquivosRajadaInvertida_Tick(object sender, EventArgs e)
        {
            Rajada rajada = new Rajada();

            List<String> listaDeArquivosEncontrados = new List<String>();
            listaDeArquivosEncontrados = rajada.retornaQuantidadeArquivosEncontrados(this.caminhoArquivoTxtRajadaTijolo, "ARQBRSINVER");

            String arquivosEncontrados = "";

            foreach (String arquivo in listaDeArquivosEncontrados)
            {
                arquivosEncontrados = arquivosEncontrados + " \n " + arquivo;
            }
            // ** Adiciona o total de arquivos encontrados ao fim da lista que irá no corpo do e-mail ** //
            arquivosEncontrados = arquivosEncontrados + " \n \n \n " + "Total de Arquivos:  " + listaDeArquivosEncontrados.Count();

            String horaAtual = DateTime.Now.ToString();

            Email email = new Email();
            email.enviarEmail(this.destinatariosRajadaInvertida, "Monitoramento de Rajadas Invertidas - " + horaAtual, "Arquivos lógicos RAJADA INVERTIDA encontrados até " + horaAtual + " \n " + arquivosEncontrados);
        }

        private void btSalvarMonitoramentoTijolo_Click(object sender, EventArgs e)
        {
            
        }

        private void btSalvarMonitoramentoDigital_Click(object sender, EventArgs e)
        {

        }

        private void btSalvarMonitoramentoInvertida_Click(object sender, EventArgs e)
        {

        }
    }
}
