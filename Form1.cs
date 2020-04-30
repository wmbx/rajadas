using System;
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

        private String caminhoArquivoTxtRajadaDigital;
        private String caminhoArquivoExcelRajadaDigital;
        private String caminhoRajadaProcessadaDigital;
        private String parametroCopiarOuMoverRajadaDigital;
        private String parametroIntervaloRajadaDigital;
        private String parametroFrequenciaRajadaDigital;

        private String caminhoArquivoTxtRajadaInvertida;
        private String caminhoArquivoExcelRajadaInvertida;
        private String caminhoRajadaProcessadaInvertida;
        private String parametroCopiarOuMoverRajadaInvertida;
        private String parametroIntervaloRajadaInvertida;
        private String parametroFrequenciaRajadaInvertida;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmRajadaTijolo.Enabled = true;
            tmRajadaDigital.Enabled = true;
            tmRajadaInvertida.Enabled = true;

            Agendamento agendamento = new Agendamento();

            ParametrosSistema parametrosRajada = new ParametrosSistema();
            
            // ---------------------------------- Carrega parâmetros da Rajada Tijolo -------------------------------------------------------//
            List<String> listaDeParametrosRajadaTijolo = new List<String>();

            listaDeParametrosRajadaTijolo = parametrosRajada.carregarParametrosRajada(this.caminhoArquivoDeConfiguracao, "Tijolo");
            
            this.caminhoArquivoTxtRajadaTijolo = listaDeParametrosRajadaTijolo[0];
            this.caminhoArquivoExcelRajadaTijolo = listaDeParametrosRajadaTijolo[1];
            this.caminhoRajadaProcessadaTijolo = listaDeParametrosRajadaTijolo[2];
            this.parametroCopiarOuMoverRajadaTijolo = listaDeParametrosRajadaTijolo[3];
            this.parametroIntervaloRajadaTijolo = listaDeParametrosRajadaTijolo[4];
            this.parametroFrequenciaRajadaTijolo = listaDeParametrosRajadaTijolo[5];

            tbCaminhoRajadaTijolo.Text = caminhoArquivoTxtRajadaTijolo;
            tbCaminhoArquivoExcelTijolo.Text = caminhoArquivoExcelRajadaTijolo;
            tbCaminhoRajadaProcessadaTijolo.Text = caminhoRajadaProcessadaTijolo;
            tbIntervaloRajadaTijolo.Text = parametroIntervaloRajadaTijolo;
            cbFrequenciaRajadaTijolo.SelectedItem = parametroFrequenciaRajadaTijolo;

            if (parametroCopiarOuMoverRajadaTijolo == "Copiar Arquivo Processado")
            {
                rbCopiarArquivoProcessadoRajadaTijolo.Checked = true;
            }
            else
            {
                rbMoverArquivoProcessadoRajadaTijolo.Checked = true;
            }
            // ---------------------------------- Carrega parâmetros da Rajada Tijolo ---------------------------------------------------------//


            // ---------------------------------- Carrega parâmetros da Rajada Digital --------------------------------------------------------//
            List<String> listaDeParametrosRajadaDigital = new List<String>();

            listaDeParametrosRajadaDigital = parametrosRajada.carregarParametrosRajada(this.caminhoArquivoDeConfiguracao, "Digital");

            this.caminhoArquivoTxtRajadaDigital = listaDeParametrosRajadaDigital[0];
            this.caminhoArquivoExcelRajadaDigital = listaDeParametrosRajadaDigital[1];
            this.caminhoRajadaProcessadaDigital = listaDeParametrosRajadaDigital[2];
            this.parametroCopiarOuMoverRajadaDigital = listaDeParametrosRajadaDigital[3];
            this.parametroIntervaloRajadaDigital = listaDeParametrosRajadaDigital[4];
            this.parametroFrequenciaRajadaDigital = listaDeParametrosRajadaDigital[5];

            tbCaminhoRajadaDigital.Text = caminhoArquivoTxtRajadaDigital;
            tbCaminhoArquivoExcelRajadaDigital.Text = caminhoArquivoExcelRajadaDigital;
            tbCaminhoRajadaProcessadaDigital.Text = caminhoRajadaProcessadaDigital;
            tbIntervaloRajadaDigital.Text = parametroIntervaloRajadaDigital;
            cbFrequenciaRajadaDigital.SelectedItem = parametroFrequenciaRajadaDigital;

            if (parametroCopiarOuMoverRajadaDigital == "Copiar Arquivo Processado")
            {
                rbCopiarArquivoProcessadoRajadaDigital.Checked = true;
            }
            else
            {
                rbMoverArquivoProcessadoRajadaDigital.Checked = true;
            }
            // ---------------------------------- Carrega parâmetros da Rajada Digital --------------------------------------------------------//


            // ---------------------------------- Carrega parâmetros da Rajada Invertida --------------------------------------------------//
            List<String> listaDeParametrosRajadaInvertida = new List<String>();

            listaDeParametrosRajadaInvertida = parametrosRajada.carregarParametrosRajada(this.caminhoArquivoDeConfiguracao, "Invertida");

            this.caminhoArquivoTxtRajadaInvertida = listaDeParametrosRajadaInvertida[0];
            this.caminhoArquivoExcelRajadaInvertida = listaDeParametrosRajadaInvertida[1];
            this.caminhoRajadaProcessadaInvertida = listaDeParametrosRajadaInvertida[2];
            this.parametroCopiarOuMoverRajadaInvertida = listaDeParametrosRajadaInvertida[3];
            this.parametroIntervaloRajadaInvertida = listaDeParametrosRajadaInvertida[4];
            this.parametroFrequenciaRajadaInvertida = listaDeParametrosRajadaInvertida[5];

            tbCaminhoRajadaInvertida.Text = caminhoArquivoTxtRajadaInvertida;
            tbCaminhoArquivoExcelRajadaInvertida.Text = caminhoArquivoExcelRajadaInvertida;
            tbCaminhoRajadaProcessadaInvertida.Text = caminhoRajadaProcessadaInvertida;
            tbIntervaloRajadaInvertida.Text = parametroIntervaloRajadaInvertida;
            cbFrequenciaRajadaInvertida.SelectedItem = parametroFrequenciaRajadaInvertida;

            if (parametroCopiarOuMoverRajadaInvertida == "Copiar Arquivo Processado")
            {
                rbCopiarArquivoProcessadoRajadaInvertida.Checked = true;
            }
            else
            {
                rbMoverArquivoProcessadoRajadaInvertida.Checked = true;
            }
            // ---------------------------------- Carrega parâmetros da Rajada Invertida ----------------------------------------------------//

            // ---------------------------------- ** Seta os agendamentos das leituras no timer da Rajada Tijolo ** --------------------------------//
            tmRajadaTijolo.Interval = agendamento.retornaAgendamentoExecucao(parametroIntervaloRajadaTijolo, parametroFrequenciaRajadaTijolo);
            // ---------------------------------- ** Seta os agendamentos das leituras no timer da Rajada Tijolo ** --------------------------------//

            // ---------------------------------- ** Seta os agendamentos das leituras no timer da Rajada Digital ** --------------------------------//
            tmRajadaDigital.Interval = agendamento.retornaAgendamentoExecucao(parametroIntervaloRajadaDigital, parametroFrequenciaRajadaDigital);
            // ---------------------------------- ** Seta os agendamentos das leituras no timer Digital ** --------------------------------//

            // ---------------------------------- ** Seta os agendamentos das leituras no timerda Rajada Invertida ** --------------------------------//
            tmRajadaInvertida.Interval = agendamento.retornaAgendamentoExecucao(parametroIntervaloRajadaInvertida, parametroFrequenciaRajadaInvertida);
            // ---------------------------------- ** Seta os agendamentos das leituras no timer da Rajada Invertida ** --------------------------------//
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Rajada rajada = new Rajada();
            
            List<Rajada> listaDeObjetosRajada = new List<Rajada>();

            Excel arquivoExcel = new Excel();

            // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//
            listaDeObjetosRajada = rajada.lerArquivoTxtRajadaTijolo(caminhoArquivoTxtRajadaTijolo, caminhoRajadaProcessadaTijolo, parametroCopiarOuMoverRajadaTijolo);            
            arquivoExcel.inserirObjetoNaPlanilhaExcel(listaDeObjetosRajada, caminhoArquivoExcelRajadaTijolo);
            // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//


            // ------------------------** Lê Rajada Digital Mundo Velho e Insere no Excel ** -----------------------------//
            listaDeObjetosRajada = rajada.lerArquivoTxtRajadaDigital(caminhoArquivoTxtRajadaDigital, caminhoRajadaProcessadaDigital, parametroCopiarOuMoverRajadaDigital);
            arquivoExcel.inserirObjetoNaPlanilhaExcel(listaDeObjetosRajada, caminhoArquivoExcelRajadaDigital);
            // ------------------------** Lê Rajada Digital Mundo Velho e Insere no Excel ** -----------------------------//


            // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//
            listaDeObjetosRajada = rajada.lerArquivoTxtRajadaInvertida(caminhoArquivoTxtRajadaInvertida, caminhoRajadaProcessadaInvertida, parametroCopiarOuMoverRajadaInvertida);
            arquivoExcel.inserirObjetoNaPlanilhaExcel(listaDeObjetosRajada, caminhoArquivoExcelRajadaInvertida);
            // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//


            MessageBox.Show("Processamento Concluído !!!", "Mensagem do sistema");
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
            OpenFileDialog abrirArquivoExcel = new OpenFileDialog();
            abrirArquivoExcel.Title = "Abrir Arquivo Excel";
            abrirArquivoExcel.Filter = "Arquivos Excel | *.xls;*.xlsx;";
            if(abrirArquivoExcel.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivoExcelRajadaTijolo = abrirArquivoExcel.FileName;
                tbCaminhoArquivoExcelTijolo.Text = caminhoArquivoExcelRajadaTijolo;
            }
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
            List<String> listaDeParametrosParaSalvar = new List<String>();

            this.parametroIntervaloRajadaTijolo = tbIntervaloRajadaTijolo.Text;
            this.parametroFrequenciaRajadaTijolo = cbFrequenciaRajadaTijolo.SelectedItem.ToString();

            if (rbCopiarArquivoProcessadoRajadaTijolo.Checked)
            {
                parametroCopiarOuMoverRajadaTijolo = rbCopiarArquivoProcessadoRajadaTijolo.Text;
            }
            else
            {
                parametroCopiarOuMoverRajadaTijolo = rbMoverArquivoProcessadoRajadaTijolo.Text;
            }
                       
            listaDeParametrosParaSalvar.Add(this.caminhoArquivoTxtRajadaTijolo);
            listaDeParametrosParaSalvar.Add(this.caminhoArquivoExcelRajadaTijolo);
            listaDeParametrosParaSalvar.Add(this.caminhoRajadaProcessadaTijolo);
            listaDeParametrosParaSalvar.Add(this.parametroCopiarOuMoverRajadaTijolo);
            listaDeParametrosParaSalvar.Add(this.parametroIntervaloRajadaTijolo);
            listaDeParametrosParaSalvar.Add(this.parametroFrequenciaRajadaTijolo);

            this.parametroIntervaloRajadaDigital = tbIntervaloRajadaDigital.Text;
            this.parametroFrequenciaRajadaDigital = cbFrequenciaRajadaDigital.SelectedItem.ToString();

            if (rbCopiarArquivoProcessadoRajadaDigital.Checked)
            {
                parametroCopiarOuMoverRajadaDigital = rbCopiarArquivoProcessadoRajadaDigital.Text;
            }
            else
            {
                parametroCopiarOuMoverRajadaDigital = rbMoverArquivoProcessadoRajadaDigital.Text;
            }

            listaDeParametrosParaSalvar.Add(this.caminhoArquivoTxtRajadaDigital);
            listaDeParametrosParaSalvar.Add(this.caminhoArquivoExcelRajadaDigital);
            listaDeParametrosParaSalvar.Add(this.caminhoRajadaProcessadaDigital);
            listaDeParametrosParaSalvar.Add(this.parametroCopiarOuMoverRajadaDigital);
            listaDeParametrosParaSalvar.Add(this.parametroIntervaloRajadaDigital);
            listaDeParametrosParaSalvar.Add(this.parametroFrequenciaRajadaDigital);

            this.parametroIntervaloRajadaInvertida = tbIntervaloRajadaInvertida.Text;
            this.parametroFrequenciaRajadaInvertida = cbFrequenciaRajadaInvertida.SelectedItem.ToString();

            if (rbCopiarArquivoProcessadoRajadaInvertida.Checked)
            {
                parametroCopiarOuMoverRajadaInvertida = rbCopiarArquivoProcessadoRajadaInvertida.Text;
            }
            else
            {
                parametroCopiarOuMoverRajadaInvertida = rbMoverArquivoProcessadoRajadaInvertida.Text;
            }

            listaDeParametrosParaSalvar.Add(this.caminhoArquivoTxtRajadaInvertida);
            listaDeParametrosParaSalvar.Add(this.caminhoArquivoExcelRajadaInvertida);
            listaDeParametrosParaSalvar.Add(this.caminhoRajadaProcessadaInvertida);
            listaDeParametrosParaSalvar.Add(this.parametroCopiarOuMoverRajadaInvertida);
            listaDeParametrosParaSalvar.Add(this.parametroIntervaloRajadaInvertida);
            listaDeParametrosParaSalvar.Add(this.parametroFrequenciaRajadaInvertida);

            ParametrosSistema parametrosSistema = new ParametrosSistema();
            parametrosSistema.salvarConfiguracoes(listaDeParametrosParaSalvar, this.caminhoArquivoDeConfiguracao, "Tijolo", 0, 5);
            parametrosSistema.salvarConfiguracoes(listaDeParametrosParaSalvar, this.caminhoArquivoDeConfiguracao, "Digital", 6, 11);
            parametrosSistema.salvarConfiguracoes(listaDeParametrosParaSalvar, this.caminhoArquivoDeConfiguracao, "Invertida", 12, 17);

            MessageBox.Show("As configurações foram salvas, o aplicativo será reiniciado automaticamente !!!", "Mensagem do sistema");

            Application.Restart();
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
            OpenFileDialog abrirArquivoExcel = new OpenFileDialog();
            abrirArquivoExcel.Title = "Abrir Arquivo Excel";
            abrirArquivoExcel.Filter = "Arquivos Excel | *.xls;*.xlsx;";
            if (abrirArquivoExcel.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivoExcelRajadaDigital = abrirArquivoExcel.FileName;
                tbCaminhoArquivoExcelRajadaDigital.Text = caminhoArquivoExcelRajadaDigital;
            }
        }

        private void btCaminhoArquivoExcelRajadaTrintaTrinta_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivoExcel = new OpenFileDialog();
            abrirArquivoExcel.Title = "Abrir Arquivo Excel";
            abrirArquivoExcel.Filter = "Arquivos Excel | *.xls;*.xlsx;";
            if (abrirArquivoExcel.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivoExcelRajadaInvertida = abrirArquivoExcel.FileName;
                tbCaminhoArquivoExcelRajadaInvertida.Text = caminhoArquivoExcelRajadaInvertida;
            }
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
            Rajada rajada = new Rajada();

            List<Rajada> listaDeObjetosRajada = new List<Rajada>();

            Excel arquivoExcel = new Excel();

            // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//
            listaDeObjetosRajada = rajada.lerArquivoTxtRajadaTijolo(caminhoArquivoTxtRajadaTijolo, caminhoRajadaProcessadaTijolo, parametroCopiarOuMoverRajadaTijolo);
            arquivoExcel.inserirObjetoNaPlanilhaExcel(listaDeObjetosRajada, caminhoArquivoExcelRajadaTijolo);
            // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//
        }

        private void tmRajadaDigital_Tick(object sender, EventArgs e)
        {
            Rajada rajada = new Rajada();

            List<Rajada> listaDeObjetosRajada = new List<Rajada>();

            Excel arquivoExcel = new Excel();

            // ------------------------** Lê Rajada Digital Mundo Velho e Insere no Excel ** -----------------------------//
            listaDeObjetosRajada = rajada.lerArquivoTxtRajadaDigital(caminhoArquivoTxtRajadaDigital, caminhoRajadaProcessadaDigital, parametroCopiarOuMoverRajadaDigital);
            arquivoExcel.inserirObjetoNaPlanilhaExcel(listaDeObjetosRajada, caminhoArquivoExcelRajadaDigital);
            // ------------------------** Lê Rajada Digital Mundo Velho e Insere no Excel ** -----------------------------//
        }

        private void tmRajadaInvertida_Tick(object sender, EventArgs e)
        {
            Rajada rajada = new Rajada();

            List<Rajada> listaDeObjetosRajada = new List<Rajada>();

            Excel arquivoExcel = new Excel();

            // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//
            listaDeObjetosRajada = rajada.lerArquivoTxtRajadaInvertida(caminhoArquivoTxtRajadaInvertida, caminhoRajadaProcessadaInvertida, parametroCopiarOuMoverRajadaInvertida);
            arquivoExcel.inserirObjetoNaPlanilhaExcel(listaDeObjetosRajada, caminhoArquivoExcelRajadaInvertida);
            // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//
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
    }
}
