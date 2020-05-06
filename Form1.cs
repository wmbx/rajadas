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
        private String statusLeituraRajadaTijolo;

        private String caminhoArquivoTxtRajadaDigital;
        private String caminhoArquivoExcelRajadaDigital;
        private String caminhoRajadaProcessadaDigital;
        private String parametroCopiarOuMoverRajadaDigital;
        private String parametroIntervaloRajadaDigital;
        private String parametroFrequenciaRajadaDigital;
        private String statusLeituraRajadaDigital;

        private String caminhoArquivoTxtRajadaInvertida;
        private String caminhoArquivoExcelRajadaInvertida;
        private String caminhoRajadaProcessadaInvertida;
        private String parametroCopiarOuMoverRajadaInvertida;
        private String parametroIntervaloRajadaInvertida;
        private String parametroFrequenciaRajadaInvertida;
        private String statusLeituraRajadaInvertida;

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
            this.caminhoArquivoExcelRajadaTijolo = listaDeParametrosRajadaTijolo[1];
            this.caminhoRajadaProcessadaTijolo = listaDeParametrosRajadaTijolo[2];
            this.parametroCopiarOuMoverRajadaTijolo = listaDeParametrosRajadaTijolo[3];
            this.parametroIntervaloRajadaTijolo = listaDeParametrosRajadaTijolo[4];
            this.parametroFrequenciaRajadaTijolo = listaDeParametrosRajadaTijolo[5];
            this.statusLeituraRajadaTijolo = listaDeParametrosRajadaTijolo[6];

            tbCaminhoRajadaTijolo.Text = caminhoArquivoTxtRajadaTijolo;
            tbCaminhoArquivoExcelTijolo.Text = caminhoArquivoExcelRajadaTijolo;
            tbCaminhoRajadaProcessadaTijolo.Text = caminhoRajadaProcessadaTijolo;
            tbIntervaloRajadaTijolo.Text = parametroIntervaloRajadaTijolo;
            cbFrequenciaRajadaTijolo.SelectedItem = parametroFrequenciaRajadaTijolo;
            cbStatusLeituraTijolo.SelectedItem = statusLeituraRajadaTijolo;

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
            // ------------------ ** Ativa ou Desativa os Timers das leituras automáticas de acordo com o parâmetro ** --------------------//

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
            this.caminhoArquivoExcelRajadaDigital = listaDeParametrosRajadaDigital[1];
            this.caminhoRajadaProcessadaDigital = listaDeParametrosRajadaDigital[2];
            this.parametroCopiarOuMoverRajadaDigital = listaDeParametrosRajadaDigital[3];
            this.parametroIntervaloRajadaDigital = listaDeParametrosRajadaDigital[4];
            this.parametroFrequenciaRajadaDigital = listaDeParametrosRajadaDigital[5];
            this.statusLeituraRajadaDigital = listaDeParametrosRajadaDigital[6];

            tbCaminhoRajadaDigital.Text = caminhoArquivoTxtRajadaDigital;
            tbCaminhoArquivoExcelRajadaDigital.Text = caminhoArquivoExcelRajadaDigital;
            tbCaminhoRajadaProcessadaDigital.Text = caminhoRajadaProcessadaDigital;
            tbIntervaloRajadaDigital.Text = parametroIntervaloRajadaDigital;
            cbFrequenciaRajadaDigital.SelectedItem = parametroFrequenciaRajadaDigital;
            cbStatusLeituraDigital.SelectedItem = statusLeituraRajadaDigital;

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
            // ------------------ ** Ativa ou Desativa os Timers das leituras automáticas de acordo com o parâmetro ** --------------------//

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
            this.caminhoArquivoExcelRajadaInvertida = listaDeParametrosRajadaInvertida[1];
            this.caminhoRajadaProcessadaInvertida = listaDeParametrosRajadaInvertida[2];
            this.parametroCopiarOuMoverRajadaInvertida = listaDeParametrosRajadaInvertida[3];
            this.parametroIntervaloRajadaInvertida = listaDeParametrosRajadaInvertida[4];
            this.parametroFrequenciaRajadaInvertida = listaDeParametrosRajadaInvertida[5];
            this.statusLeituraRajadaInvertida = listaDeParametrosRajadaInvertida[6];

            tbCaminhoRajadaInvertida.Text = caminhoArquivoTxtRajadaInvertida;
            tbCaminhoArquivoExcelRajadaInvertida.Text = caminhoArquivoExcelRajadaInvertida;
            tbCaminhoRajadaProcessadaInvertida.Text = caminhoRajadaProcessadaInvertida;
            tbIntervaloRajadaInvertida.Text = parametroIntervaloRajadaInvertida;
            cbFrequenciaRajadaInvertida.SelectedItem = parametroFrequenciaRajadaInvertida;
            cbStatusLeituraInvertida.SelectedItem = statusLeituraRajadaInvertida;

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
            // ------------------ ** Ativa ou Desativa os Timers das leituras automáticas de acordo com o parâmetro ** --------------------//

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
            try
            {
                Rajada rajada = new Rajada();

                List<Rajada> listaDeObjetosRajada = new List<Rajada>();

                Excel arquivoExcel = new Excel();

                // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//
                listaDeObjetosRajada = rajada.lerArquivoTxtRajadaTijolo(caminhoArquivoTxtRajadaTijolo, caminhoRajadaProcessadaTijolo, parametroCopiarOuMoverRajadaTijolo);
                arquivoExcel.inserirObjetoNaPlanilhaExcel(listaDeObjetosRajada, caminhoArquivoExcelRajadaTijolo);
                // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//
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
                Rajada rajada = new Rajada();

                List<Rajada> listaDeObjetosRajada = new List<Rajada>();

                Excel arquivoExcel = new Excel();

                // ------------------------** Lê Rajada Digital Mundo Velho e Insere no Excel ** -----------------------------//
                listaDeObjetosRajada = rajada.lerArquivoTxtRajadaDigital(caminhoArquivoTxtRajadaDigital, caminhoRajadaProcessadaDigital, parametroCopiarOuMoverRajadaDigital);
                arquivoExcel.inserirObjetoNaPlanilhaExcel(listaDeObjetosRajada, caminhoArquivoExcelRajadaDigital);
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
                Rajada rajada = new Rajada();

                List<Rajada> listaDeObjetosRajada = new List<Rajada>();

                Excel arquivoExcel = new Excel();

                // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//
                listaDeObjetosRajada = rajada.lerArquivoTxtRajadaInvertida(caminhoArquivoTxtRajadaInvertida, caminhoRajadaProcessadaInvertida, parametroCopiarOuMoverRajadaInvertida);
                arquivoExcel.inserirObjetoNaPlanilhaExcel(listaDeObjetosRajada, caminhoArquivoExcelRajadaInvertida);
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
            if (tbIntervaloRajadaTijolo.Text.Equals("") || tbIntervaloRajadaTijolo.Text.Equals("0") || tbIntervaloRajadaDigital.Text.Equals("") || tbIntervaloRajadaDigital.Text.Equals("0") || tbIntervaloRajadaInvertida.Text.Equals("") || tbIntervaloRajadaInvertida.Text.Equals("0"))
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

                listaDeParametrosParaSalvar.Add(this.caminhoArquivoTxtRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.caminhoArquivoExcelRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.caminhoRajadaProcessadaTijolo);
                listaDeParametrosParaSalvar.Add(this.parametroCopiarOuMoverRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.parametroIntervaloRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.parametroFrequenciaRajadaTijolo);
                listaDeParametrosParaSalvar.Add(this.statusLeituraRajadaTijolo);

                ParametrosSistema parametrosSistema = new ParametrosSistema();
                parametrosSistema.salvarConfiguracoes(listaDeParametrosParaSalvar, this.caminhoArquivoDeConfiguracao, "Tijolo", 0, 6);

                MessageBox.Show("As configurações foram salvas !!!", "Mensagem do sistema");

                carregaParametrosRajadaTijolo();
            }
        }

        private void btSalvarArquivoDigital_Click(object sender, EventArgs e)
        {
            // ----- ** Validação dos campos Intervalo para não permitir a digitação de zero ou em branco ** -------- //
            if (tbIntervaloRajadaTijolo.Text.Equals("") || tbIntervaloRajadaTijolo.Text.Equals("0") || tbIntervaloRajadaDigital.Text.Equals("") || tbIntervaloRajadaDigital.Text.Equals("0") || tbIntervaloRajadaInvertida.Text.Equals("") || tbIntervaloRajadaInvertida.Text.Equals("0"))
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

                listaDeParametrosParaSalvar.Add(this.caminhoArquivoTxtRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.caminhoArquivoExcelRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.caminhoRajadaProcessadaDigital);
                listaDeParametrosParaSalvar.Add(this.parametroCopiarOuMoverRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.parametroIntervaloRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.parametroFrequenciaRajadaDigital);
                listaDeParametrosParaSalvar.Add(this.statusLeituraRajadaDigital);

                ParametrosSistema parametrosSistema = new ParametrosSistema();
                parametrosSistema.salvarConfiguracoes(listaDeParametrosParaSalvar, this.caminhoArquivoDeConfiguracao, "Digital", 0, 6);

                MessageBox.Show("As configurações foram salvas !!!", "Mensagem do sistema");

                carregaParametrosRajadaDigital();
            }
        }

        private void btSalvarArquivoInvertida_Click(object sender, EventArgs e)
        {
            // ----- ** Validação dos campos Intervalo para não permitir a digitação de zero ou em branco ** -------- //
            if (tbIntervaloRajadaTijolo.Text.Equals("") || tbIntervaloRajadaTijolo.Text.Equals("0") || tbIntervaloRajadaDigital.Text.Equals("") || tbIntervaloRajadaDigital.Text.Equals("0") || tbIntervaloRajadaInvertida.Text.Equals("") || tbIntervaloRajadaInvertida.Text.Equals("0"))
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

                listaDeParametrosParaSalvar.Add(this.caminhoArquivoTxtRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.caminhoArquivoExcelRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.caminhoRajadaProcessadaInvertida);
                listaDeParametrosParaSalvar.Add(this.parametroCopiarOuMoverRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.parametroIntervaloRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.parametroFrequenciaRajadaInvertida);
                listaDeParametrosParaSalvar.Add(this.statusLeituraRajadaInvertida);

                ParametrosSistema parametrosSistema = new ParametrosSistema();
                parametrosSistema.salvarConfiguracoes(listaDeParametrosParaSalvar, this.caminhoArquivoDeConfiguracao, "Invertida", 0, 6);

                MessageBox.Show("As configurações foram salvas !!!", "Mensagem do sistema");

                carregaParemetrosRajadaInvertida();
            }
        }

        private void btLerArquivoTijolo_Click(object sender, EventArgs e)
        {
            Rajada rajada = new Rajada();

            List<Rajada> listaDeObjetosRajada = new List<Rajada>();

            Excel arquivoExcel = new Excel();

            // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//
            listaDeObjetosRajada = rajada.lerArquivoTxtRajadaTijolo(caminhoArquivoTxtRajadaTijolo, caminhoRajadaProcessadaTijolo, parametroCopiarOuMoverRajadaTijolo);
            arquivoExcel.inserirObjetoNaPlanilhaExcel(listaDeObjetosRajada, caminhoArquivoExcelRajadaTijolo);
            // ------------------------** Lê Rajada Tijolo e Insere no Excel ** -----------------------------//
            
            // -------------------------** Mensagem ao fim da leitura manual -----------------------------------//
            MessageBox.Show("Processamento Concluído !!!", "Mensagem do sistema");
        }

        private void btLerArquivoDigital_Click(object sender, EventArgs e)
        {
            Rajada rajada = new Rajada();

            List<Rajada> listaDeObjetosRajada = new List<Rajada>();

            Excel arquivoExcel = new Excel();

            // ------------------------** Lê Rajada Digital Mundo Velho e Insere no Excel ** -----------------------------//
            listaDeObjetosRajada = rajada.lerArquivoTxtRajadaDigital(caminhoArquivoTxtRajadaDigital, caminhoRajadaProcessadaDigital, parametroCopiarOuMoverRajadaDigital);
            arquivoExcel.inserirObjetoNaPlanilhaExcel(listaDeObjetosRajada, caminhoArquivoExcelRajadaDigital);
            // ------------------------** Lê Rajada Digital Mundo Velho e Insere no Excel ** -----------------------------//

            // -------------------------** Mensagem ao fim da leitura manual -----------------------------------//
            MessageBox.Show("Processamento Concluído !!!", "Mensagem do sistema");
        }

        private void btLerArquivoInvertida_Click(object sender, EventArgs e)
        {
            Rajada rajada = new Rajada();

            List<Rajada> listaDeObjetosRajada = new List<Rajada>();

            Excel arquivoExcel = new Excel();

            // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//
            listaDeObjetosRajada = rajada.lerArquivoTxtRajadaInvertida(caminhoArquivoTxtRajadaInvertida, caminhoRajadaProcessadaInvertida, parametroCopiarOuMoverRajadaInvertida);
            arquivoExcel.inserirObjetoNaPlanilhaExcel(listaDeObjetosRajada, caminhoArquivoExcelRajadaInvertida);
            // ------------------------** Lê Rajada Invertida e Insere no Excel ** -----------------------------//

            // -------------------------** Mensagem ao fim da leitura manual -----------------------------------//
            MessageBox.Show("Processamento Concluído !!!", "Mensagem do sistema");
        }
    }
}
