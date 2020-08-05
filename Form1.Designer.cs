namespace rajadas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.apontaCaminhoPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.apontaCaminhoArquivo = new System.Windows.Forms.OpenFileDialog();
            this.tmRajadaTijolo = new System.Windows.Forms.Timer(this.components);
            this.tmRajadaDigital = new System.Windows.Forms.Timer(this.components);
            this.tmRajadaInvertida = new System.Windows.Forms.Timer(this.components);
            this.niBandeja = new System.Windows.Forms.NotifyIcon(this.components);
            this.tmMonitoramentoTijolo = new System.Windows.Forms.Timer(this.components);
            this.tmMonitoramentoDigital = new System.Windows.Forms.Timer(this.components);
            this.tmMonitoramentoInvertida = new System.Windows.Forms.Timer(this.components);
            this.tmRotinaExpurgo = new System.Windows.Forms.Timer(this.components);
            this.tmRotinaRestauracaoMonitoramento = new System.Windows.Forms.Timer(this.components);
            this.tmLeituraCSVDetalhadoRegistro = new System.Windows.Forms.Timer(this.components);
            this.tabDetalhadoProdutividade = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.btnLerCSVDpItau = new System.Windows.Forms.Button();
            this.btnSalvarConfiguracoesDpItau = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabDetalhadoRegistro = new System.Windows.Forms.TabPage();
            this.gbBradesco = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbOrigemCSVBradesco = new System.Windows.Forms.TextBox();
            this.btnOrigemCSV = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDestinoCSVBradesco = new System.Windows.Forms.TextBox();
            this.btnDestinoCSV = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalvarConfiguracoesDR = new System.Windows.Forms.Button();
            this.pbLeituraDR = new System.Windows.Forms.ProgressBar();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.cbFrequenciaLeituraDR = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbIntervaloLeituraDR = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbStatusLeituraDR = new System.Windows.Forms.ComboBox();
            this.button14 = new System.Windows.Forms.Button();
            this.gbItau = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrigemCSVItau = new System.Windows.Forms.TextBox();
            this.btnOrigemCSVITAU = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDestinoCSVItau = new System.Windows.Forms.TextBox();
            this.btnDestinoCSVITAU = new System.Windows.Forms.Button();
            this.btnLerCSVItau = new System.Windows.Forms.Button();
            this.btnSalvarConfiguracoesITAU = new System.Windows.Forms.Button();
            this.pbLeituraDRItau = new System.Windows.Forms.ProgressBar();
            this.gbDockTech = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbOrigemCSVDockTech = new System.Windows.Forms.TextBox();
            this.btnOrigemCSVDockTech = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.tbDestinoCSVDockTech = new System.Windows.Forms.TextBox();
            this.btnDestinoCSVDockTech = new System.Windows.Forms.Button();
            this.btnLerCSVDockTech = new System.Windows.Forms.Button();
            this.btnSalvarConfiguracoesDOCKTECH = new System.Windows.Forms.Button();
            this.pbLeituraDRDockTech = new System.Windows.Forms.ProgressBar();
            this.gbBMG = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbOrigemCSVBMG = new System.Windows.Forms.TextBox();
            this.btnOrigemCSVBMG = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.tbDestinoCSVBMG = new System.Windows.Forms.TextBox();
            this.btnDestinoCSVBMG = new System.Windows.Forms.Button();
            this.btnLerCSVBMG = new System.Windows.Forms.Button();
            this.btnSalvarConfiguracoesBMG = new System.Windows.Forms.Button();
            this.pbLeituraDRBMG = new System.Windows.Forms.ProgressBar();
            this.tabRajadas = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIntervaloRajadaTijolo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbFrequenciaRajadaTijolo = new System.Windows.Forms.ComboBox();
            this.lbStatusLeituraTijolo = new System.Windows.Forms.Label();
            this.btSalvarArquivoTijolo = new System.Windows.Forms.Button();
            this.cbStatusLeituraTijolo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCaminhoRajadaTijolo = new System.Windows.Forms.TextBox();
            this.btCaminhoRajadaTijolo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCaminhoRajadaProcessadaTijolo = new System.Windows.Forms.TextBox();
            this.btCaminhoRajadaProcessadaTijolo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMoverArquivoProcessadoRajadaTijolo = new System.Windows.Forms.RadioButton();
            this.rbCopiarArquivoProcessadoRajadaTijolo = new System.Windows.Forms.RadioButton();
            this.btLerArquivoTijolo = new System.Windows.Forms.Button();
            this.pbLeituraTijolo = new System.Windows.Forms.ProgressBar();
            this.gbMonitoramentoTijolo = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbStatusMonitoramentoTijolo = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbDestinatariosTijolo = new System.Windows.Forms.TextBox();
            this.btAgendamentoTijolo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbIntervaloRajadaDigital = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbMoverArquivoProcessadoRajadaDigital = new System.Windows.Forms.RadioButton();
            this.rbCopiarArquivoProcessadoRajadaDigital = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.cbFrequenciaRajadaDigital = new System.Windows.Forms.ComboBox();
            this.lbStatusLeituraDigital = new System.Windows.Forms.Label();
            this.cbStatusLeituraDigital = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCaminhoRajadaDigital = new System.Windows.Forms.TextBox();
            this.btCaminhoRajadaDigital = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCaminhoRajadaProcessadaDigital = new System.Windows.Forms.TextBox();
            this.btCaminhoRajadaProcessadaDigital = new System.Windows.Forms.Button();
            this.btSalvarArquivoDigital = new System.Windows.Forms.Button();
            this.btLerArquivoDigital = new System.Windows.Forms.Button();
            this.pbLeituraDigital = new System.Windows.Forms.ProgressBar();
            this.gbMonitoramentoDigital = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbStatusMonitoramentoDigital = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbDestinatariosDigital = new System.Windows.Forms.TextBox();
            this.btAgendamentoDigital = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbIntervaloRajadaInvertida = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbFrequenciaRajadaInvertida = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbStatusLeituraInvertida = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCaminhoRajadaInvertida = new System.Windows.Forms.TextBox();
            this.btApontaCaminhoRajadaTrintaTrinta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCaminhoRajadaProcessadaInvertida = new System.Windows.Forms.TextBox();
            this.btCaminhoRajadaProcessadaTrintaTrinta = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbMoverArquivoProcessadoRajadaInvertida = new System.Windows.Forms.RadioButton();
            this.rbCopiarArquivoProcessadoRajadaInvertida = new System.Windows.Forms.RadioButton();
            this.btSalvarArquivoInvertida = new System.Windows.Forms.Button();
            this.btLerArquivoInvertida = new System.Windows.Forms.Button();
            this.pbLeituraInvertida = new System.Windows.Forms.ProgressBar();
            this.gbMonitoramentoInvertida = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cbStatusMonitoramentoInvertida = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbDestinatariosInvertida = new System.Windows.Forms.TextBox();
            this.btAgendamentoInvertida = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDetalhadoProdutividade.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabDetalhadoRegistro.SuspendLayout();
            this.gbBradesco.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.gbItau.SuspendLayout();
            this.gbDockTech.SuspendLayout();
            this.gbBMG.SuspendLayout();
            this.tabRajadas.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbMonitoramentoTijolo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbMonitoramentoDigital.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbMonitoramentoInvertida.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // apontaCaminhoPasta
            // 
            this.apontaCaminhoPasta.HelpRequest += new System.EventHandler(this.apontaCaminhoRajada_HelpRequest);
            // 
            // apontaCaminhoArquivo
            // 
            this.apontaCaminhoArquivo.FileName = "openFileDialog1";
            // 
            // tmRajadaTijolo
            // 
            this.tmRajadaTijolo.Interval = 1000;
            this.tmRajadaTijolo.Tick += new System.EventHandler(this.tmRajadaTijolo_Tick);
            // 
            // tmRajadaDigital
            // 
            this.tmRajadaDigital.Interval = 1000;
            this.tmRajadaDigital.Tick += new System.EventHandler(this.tmRajadaDigital_Tick);
            // 
            // tmRajadaInvertida
            // 
            this.tmRajadaInvertida.Interval = 1000;
            this.tmRajadaInvertida.Tick += new System.EventHandler(this.tmRajadaInvertida_Tick);
            // 
            // niBandeja
            // 
            this.niBandeja.Icon = ((System.Drawing.Icon)(resources.GetObject("niBandeja.Icon")));
            this.niBandeja.Text = "BotFlow Rajadas";
            this.niBandeja.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niBandeja_MouseDoubleClick);
            // 
            // tmMonitoramentoTijolo
            // 
            this.tmMonitoramentoTijolo.Interval = 30000;
            this.tmMonitoramentoTijolo.Tick += new System.EventHandler(this.tmMonitoramentoTijolo_Tick);
            // 
            // tmMonitoramentoDigital
            // 
            this.tmMonitoramentoDigital.Interval = 30000;
            this.tmMonitoramentoDigital.Tick += new System.EventHandler(this.tmMonitoramentoDigital_Tick);
            // 
            // tmMonitoramentoInvertida
            // 
            this.tmMonitoramentoInvertida.Interval = 30000;
            this.tmMonitoramentoInvertida.Tick += new System.EventHandler(this.tmMonitoramentoInvertida_Tick);
            // 
            // tmRotinaExpurgo
            // 
            this.tmRotinaExpurgo.Enabled = true;
            this.tmRotinaExpurgo.Interval = 36000000;
            this.tmRotinaExpurgo.Tick += new System.EventHandler(this.tmRotinaExpurgo_Tick);
            // 
            // tmRotinaRestauracaoMonitoramento
            // 
            this.tmRotinaRestauracaoMonitoramento.Enabled = true;
            this.tmRotinaRestauracaoMonitoramento.Interval = 30000;
            this.tmRotinaRestauracaoMonitoramento.Tick += new System.EventHandler(this.tmRotinaRestauracaoMonitoramento_Tick);
            // 
            // tmLeituraCSVDetalhadoRegistro
            // 
            this.tmLeituraCSVDetalhadoRegistro.Interval = 1000;
            this.tmLeituraCSVDetalhadoRegistro.Tick += new System.EventHandler(this.tmLeituraCSVDetalhadoRegistro_Tick);
            // 
            // tabDetalhadoProdutividade
            // 
            this.tabDetalhadoProdutividade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDetalhadoProdutividade.BackgroundImage")));
            this.tabDetalhadoProdutividade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDetalhadoProdutividade.Controls.Add(this.groupBox11);
            this.tabDetalhadoProdutividade.Controls.Add(this.groupBox13);
            this.tabDetalhadoProdutividade.Controls.Add(this.groupBox14);
            this.tabDetalhadoProdutividade.Controls.Add(this.groupBox15);
            this.tabDetalhadoProdutividade.Controls.Add(this.groupBox16);
            this.tabDetalhadoProdutividade.Location = new System.Drawing.Point(4, 22);
            this.tabDetalhadoProdutividade.Name = "tabDetalhadoProdutividade";
            this.tabDetalhadoProdutividade.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalhadoProdutividade.Size = new System.Drawing.Size(997, 481);
            this.tabDetalhadoProdutividade.TabIndex = 3;
            this.tabDetalhadoProdutividade.Text = "Detalhado de Produtividade";
            this.tabDetalhadoProdutividade.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.progressBar4);
            this.groupBox16.Controls.Add(this.button16);
            this.groupBox16.Controls.Add(this.button17);
            this.groupBox16.Controls.Add(this.button18);
            this.groupBox16.Controls.Add(this.textBox8);
            this.groupBox16.Controls.Add(this.label40);
            this.groupBox16.Controls.Add(this.button19);
            this.groupBox16.Controls.Add(this.textBox9);
            this.groupBox16.Controls.Add(this.label41);
            this.groupBox16.Location = new System.Drawing.Point(312, 3);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(663, 113);
            this.groupBox16.TabIndex = 11;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "BRADESCO";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(7, 23);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(79, 13);
            this.label41.TabIndex = 1;
            this.label41.Text = "Origem do CSV";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(9, 38);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(438, 20);
            this.textBox9.TabIndex = 3;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(448, 37);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(26, 22);
            this.button19.TabIndex = 5;
            this.button19.Text = "...";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(7, 64);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(154, 13);
            this.label40.TabIndex = 7;
            this.label40.Text = "Destino do arquivo processado";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(10, 79);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(438, 20);
            this.textBox8.TabIndex = 8;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(449, 78);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(26, 22);
            this.button18.TabIndex = 9;
            this.button18.Text = "...";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(494, 38);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(159, 21);
            this.button17.TabIndex = 1;
            this.button17.Text = "Ler Arquivo";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(494, 78);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(159, 22);
            this.button16.TabIndex = 16;
            this.button16.Text = "Salvar Configurações";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(494, 37);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(159, 21);
            this.progressBar4.TabIndex = 15;
            this.progressBar4.Visible = false;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.button15);
            this.groupBox15.Controls.Add(this.comboBox1);
            this.groupBox15.Controls.Add(this.label37);
            this.groupBox15.Controls.Add(this.label38);
            this.groupBox15.Controls.Add(this.textBox7);
            this.groupBox15.Controls.Add(this.label39);
            this.groupBox15.Controls.Add(this.comboBox2);
            this.groupBox15.Location = new System.Drawing.Point(15, 186);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(282, 113);
            this.groupBox15.TabIndex = 12;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Configurações da Leitura";
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Segundo";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.comboBox2.Location = new System.Drawing.Point(198, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(72, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(197, 23);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(60, 13);
            this.label39.TabIndex = 5;
            this.label39.Text = "Frequência";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(144, 39);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(31, 20);
            this.textBox7.TabIndex = 4;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(142, 23);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(48, 13);
            this.label38.TabIndex = 2;
            this.label38.Text = "Intervalo";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(8, 23);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(94, 13);
            this.label37.TabIndex = 7;
            this.label37.Text = "Leitura automática";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Segundo";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ativada",
            "Desativada"});
            this.comboBox1.Location = new System.Drawing.Point(11, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(11, 69);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(259, 22);
            this.button15.TabIndex = 17;
            this.button15.Text = "Salvar Configurações";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.progressBar3);
            this.groupBox14.Controls.Add(this.btnSalvarConfiguracoesDpItau);
            this.groupBox14.Controls.Add(this.btnLerCSVDpItau);
            this.groupBox14.Controls.Add(this.button12);
            this.groupBox14.Controls.Add(this.textBox5);
            this.groupBox14.Controls.Add(this.label35);
            this.groupBox14.Controls.Add(this.button13);
            this.groupBox14.Controls.Add(this.textBox6);
            this.groupBox14.Controls.Add(this.label36);
            this.groupBox14.Location = new System.Drawing.Point(312, 122);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(663, 113);
            this.groupBox14.TabIndex = 13;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "ITAÚ";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(7, 23);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(79, 13);
            this.label36.TabIndex = 1;
            this.label36.Text = "Origem do CSV";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(9, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(438, 20);
            this.textBox6.TabIndex = 3;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(448, 37);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(26, 22);
            this.button13.TabIndex = 5;
            this.button13.Text = "...";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(7, 64);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(154, 13);
            this.label35.TabIndex = 7;
            this.label35.Text = "Destino do arquivo processado";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(10, 79);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(438, 20);
            this.textBox5.TabIndex = 8;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(449, 78);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(26, 22);
            this.button12.TabIndex = 9;
            this.button12.Text = "...";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // btnLerCSVDpItau
            // 
            this.btnLerCSVDpItau.Location = new System.Drawing.Point(494, 38);
            this.btnLerCSVDpItau.Name = "btnLerCSVDpItau";
            this.btnLerCSVDpItau.Size = new System.Drawing.Size(159, 21);
            this.btnLerCSVDpItau.TabIndex = 1;
            this.btnLerCSVDpItau.Text = "Ler Arquivo";
            this.btnLerCSVDpItau.UseVisualStyleBackColor = true;
            this.btnLerCSVDpItau.Click += new System.EventHandler(this.btnLerCSVDpItau_Click);
            // 
            // btnSalvarConfiguracoesDpItau
            // 
            this.btnSalvarConfiguracoesDpItau.Location = new System.Drawing.Point(494, 78);
            this.btnSalvarConfiguracoesDpItau.Name = "btnSalvarConfiguracoesDpItau";
            this.btnSalvarConfiguracoesDpItau.Size = new System.Drawing.Size(159, 22);
            this.btnSalvarConfiguracoesDpItau.TabIndex = 16;
            this.btnSalvarConfiguracoesDpItau.Text = "Salvar Configurações";
            this.btnSalvarConfiguracoesDpItau.UseVisualStyleBackColor = true;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(494, 37);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(159, 21);
            this.progressBar3.TabIndex = 15;
            this.progressBar3.Visible = false;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.progressBar2);
            this.groupBox13.Controls.Add(this.button6);
            this.groupBox13.Controls.Add(this.button7);
            this.groupBox13.Controls.Add(this.button8);
            this.groupBox13.Controls.Add(this.textBox3);
            this.groupBox13.Controls.Add(this.label33);
            this.groupBox13.Controls.Add(this.button9);
            this.groupBox13.Controls.Add(this.textBox4);
            this.groupBox13.Controls.Add(this.label34);
            this.groupBox13.Location = new System.Drawing.Point(312, 241);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(663, 113);
            this.groupBox13.TabIndex = 14;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "DOCK TECH";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(7, 23);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(79, 13);
            this.label34.TabIndex = 1;
            this.label34.Text = "Origem do CSV";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(438, 20);
            this.textBox4.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(448, 37);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(26, 22);
            this.button9.TabIndex = 5;
            this.button9.Text = "...";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 64);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(154, 13);
            this.label33.TabIndex = 7;
            this.label33.Text = "Destino do arquivo processado";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(438, 20);
            this.textBox3.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(449, 78);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(26, 22);
            this.button8.TabIndex = 9;
            this.button8.Text = "...";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(494, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 21);
            this.button7.TabIndex = 1;
            this.button7.Text = "Ler Arquivo";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(494, 78);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 22);
            this.button6.TabIndex = 16;
            this.button6.Text = "Salvar Configurações";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(494, 37);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(159, 21);
            this.progressBar2.TabIndex = 15;
            this.progressBar2.Visible = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.progressBar1);
            this.groupBox11.Controls.Add(this.button1);
            this.groupBox11.Controls.Add(this.button3);
            this.groupBox11.Controls.Add(this.button4);
            this.groupBox11.Controls.Add(this.textBox1);
            this.groupBox11.Controls.Add(this.label31);
            this.groupBox11.Controls.Add(this.button5);
            this.groupBox11.Controls.Add(this.textBox2);
            this.groupBox11.Controls.Add(this.label32);
            this.groupBox11.Location = new System.Drawing.Point(312, 360);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(663, 113);
            this.groupBox11.TabIndex = 15;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "BMG";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 23);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(79, 13);
            this.label32.TabIndex = 1;
            this.label32.Text = "Origem do CSV";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(438, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(448, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 22);
            this.button5.TabIndex = 5;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 64);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(154, 13);
            this.label31.TabIndex = 7;
            this.label31.Text = "Destino do arquivo processado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(449, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 22);
            this.button4.TabIndex = 9;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 21);
            this.button3.TabIndex = 1;
            this.button3.Text = "Ler Arquivo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 22);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salvar Configurações";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(494, 37);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(159, 21);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Visible = false;
            // 
            // tabDetalhadoRegistro
            // 
            this.tabDetalhadoRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDetalhadoRegistro.BackgroundImage")));
            this.tabDetalhadoRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDetalhadoRegistro.Controls.Add(this.gbBMG);
            this.tabDetalhadoRegistro.Controls.Add(this.gbDockTech);
            this.tabDetalhadoRegistro.Controls.Add(this.gbItau);
            this.tabDetalhadoRegistro.Controls.Add(this.groupBox12);
            this.tabDetalhadoRegistro.Controls.Add(this.gbBradesco);
            this.tabDetalhadoRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabDetalhadoRegistro.Name = "tabDetalhadoRegistro";
            this.tabDetalhadoRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalhadoRegistro.Size = new System.Drawing.Size(997, 481);
            this.tabDetalhadoRegistro.TabIndex = 1;
            this.tabDetalhadoRegistro.Text = "Detalhado de Registro";
            this.tabDetalhadoRegistro.UseVisualStyleBackColor = true;
            // 
            // gbBradesco
            // 
            this.gbBradesco.Controls.Add(this.pbLeituraDR);
            this.gbBradesco.Controls.Add(this.btnSalvarConfiguracoesDR);
            this.gbBradesco.Controls.Add(this.button2);
            this.gbBradesco.Controls.Add(this.btnDestinoCSV);
            this.gbBradesco.Controls.Add(this.tbDestinoCSVBradesco);
            this.gbBradesco.Controls.Add(this.label9);
            this.gbBradesco.Controls.Add(this.btnOrigemCSV);
            this.gbBradesco.Controls.Add(this.tbOrigemCSVBradesco);
            this.gbBradesco.Controls.Add(this.label18);
            this.gbBradesco.Location = new System.Drawing.Point(312, 3);
            this.gbBradesco.Name = "gbBradesco";
            this.gbBradesco.Size = new System.Drawing.Size(663, 113);
            this.gbBradesco.TabIndex = 11;
            this.gbBradesco.TabStop = false;
            this.gbBradesco.Text = "BRADESCO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Origem do CSV";
            // 
            // tbOrigemCSVBradesco
            // 
            this.tbOrigemCSVBradesco.Location = new System.Drawing.Point(9, 38);
            this.tbOrigemCSVBradesco.Name = "tbOrigemCSVBradesco";
            this.tbOrigemCSVBradesco.Size = new System.Drawing.Size(438, 20);
            this.tbOrigemCSVBradesco.TabIndex = 3;
            // 
            // btnOrigemCSV
            // 
            this.btnOrigemCSV.Location = new System.Drawing.Point(448, 37);
            this.btnOrigemCSV.Name = "btnOrigemCSV";
            this.btnOrigemCSV.Size = new System.Drawing.Size(26, 22);
            this.btnOrigemCSV.TabIndex = 5;
            this.btnOrigemCSV.Text = "...";
            this.btnOrigemCSV.UseVisualStyleBackColor = true;
            this.btnOrigemCSV.Click += new System.EventHandler(this.btnOrigemCSV_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Destino do arquivo processado";
            // 
            // tbDestinoCSVBradesco
            // 
            this.tbDestinoCSVBradesco.Location = new System.Drawing.Point(10, 79);
            this.tbDestinoCSVBradesco.Name = "tbDestinoCSVBradesco";
            this.tbDestinoCSVBradesco.Size = new System.Drawing.Size(438, 20);
            this.tbDestinoCSVBradesco.TabIndex = 8;
            // 
            // btnDestinoCSV
            // 
            this.btnDestinoCSV.Location = new System.Drawing.Point(449, 78);
            this.btnDestinoCSV.Name = "btnDestinoCSV";
            this.btnDestinoCSV.Size = new System.Drawing.Size(26, 22);
            this.btnDestinoCSV.TabIndex = 9;
            this.btnDestinoCSV.Text = "...";
            this.btnDestinoCSV.UseVisualStyleBackColor = true;
            this.btnDestinoCSV.Click += new System.EventHandler(this.btnDestinoCSV_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ler Arquivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalvarConfiguracoesDR
            // 
            this.btnSalvarConfiguracoesDR.Location = new System.Drawing.Point(494, 78);
            this.btnSalvarConfiguracoesDR.Name = "btnSalvarConfiguracoesDR";
            this.btnSalvarConfiguracoesDR.Size = new System.Drawing.Size(159, 22);
            this.btnSalvarConfiguracoesDR.TabIndex = 16;
            this.btnSalvarConfiguracoesDR.Text = "Salvar Configurações";
            this.btnSalvarConfiguracoesDR.UseVisualStyleBackColor = true;
            this.btnSalvarConfiguracoesDR.Click += new System.EventHandler(this.btnSalvarConfiguracoesDR_Click);
            // 
            // pbLeituraDR
            // 
            this.pbLeituraDR.Location = new System.Drawing.Point(494, 37);
            this.pbLeituraDR.Name = "pbLeituraDR";
            this.pbLeituraDR.Size = new System.Drawing.Size(159, 21);
            this.pbLeituraDR.TabIndex = 15;
            this.pbLeituraDR.Visible = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button14);
            this.groupBox12.Controls.Add(this.cbStatusLeituraDR);
            this.groupBox12.Controls.Add(this.label19);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.Controls.Add(this.tbIntervaloLeituraDR);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Controls.Add(this.cbFrequenciaLeituraDR);
            this.groupBox12.Location = new System.Drawing.Point(15, 186);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(282, 113);
            this.groupBox12.TabIndex = 12;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Configurações da Leitura";
            // 
            // cbFrequenciaLeituraDR
            // 
            this.cbFrequenciaLeituraDR.DisplayMember = "Segundo";
            this.cbFrequenciaLeituraDR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrequenciaLeituraDR.FormattingEnabled = true;
            this.cbFrequenciaLeituraDR.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.cbFrequenciaLeituraDR.Location = new System.Drawing.Point(198, 38);
            this.cbFrequenciaLeituraDR.Name = "cbFrequenciaLeituraDR";
            this.cbFrequenciaLeituraDR.Size = new System.Drawing.Size(72, 21);
            this.cbFrequenciaLeituraDR.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(197, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Frequência";
            // 
            // tbIntervaloLeituraDR
            // 
            this.tbIntervaloLeituraDR.Location = new System.Drawing.Point(144, 39);
            this.tbIntervaloLeituraDR.Name = "tbIntervaloLeituraDR";
            this.tbIntervaloLeituraDR.Size = new System.Drawing.Size(31, 20);
            this.tbIntervaloLeituraDR.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(142, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Intervalo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Leitura automática";
            // 
            // cbStatusLeituraDR
            // 
            this.cbStatusLeituraDR.DisplayMember = "Segundo";
            this.cbStatusLeituraDR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusLeituraDR.FormattingEnabled = true;
            this.cbStatusLeituraDR.Items.AddRange(new object[] {
            "Ativada",
            "Desativada"});
            this.cbStatusLeituraDR.Location = new System.Drawing.Point(11, 38);
            this.cbStatusLeituraDR.Name = "cbStatusLeituraDR";
            this.cbStatusLeituraDR.Size = new System.Drawing.Size(122, 21);
            this.cbStatusLeituraDR.TabIndex = 8;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(11, 69);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(259, 22);
            this.button14.TabIndex = 17;
            this.button14.Text = "Salvar Configurações";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // gbItau
            // 
            this.gbItau.Controls.Add(this.pbLeituraDRItau);
            this.gbItau.Controls.Add(this.btnSalvarConfiguracoesITAU);
            this.gbItau.Controls.Add(this.btnLerCSVItau);
            this.gbItau.Controls.Add(this.btnDestinoCSVITAU);
            this.gbItau.Controls.Add(this.tbDestinoCSVItau);
            this.gbItau.Controls.Add(this.label2);
            this.gbItau.Controls.Add(this.btnOrigemCSVITAU);
            this.gbItau.Controls.Add(this.tbOrigemCSVItau);
            this.gbItau.Controls.Add(this.label5);
            this.gbItau.Location = new System.Drawing.Point(312, 122);
            this.gbItau.Name = "gbItau";
            this.gbItau.Size = new System.Drawing.Size(663, 113);
            this.gbItau.TabIndex = 13;
            this.gbItau.TabStop = false;
            this.gbItau.Text = "ITAÚ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Origem do CSV";
            // 
            // tbOrigemCSVItau
            // 
            this.tbOrigemCSVItau.Location = new System.Drawing.Point(9, 38);
            this.tbOrigemCSVItau.Name = "tbOrigemCSVItau";
            this.tbOrigemCSVItau.Size = new System.Drawing.Size(438, 20);
            this.tbOrigemCSVItau.TabIndex = 3;
            // 
            // btnOrigemCSVITAU
            // 
            this.btnOrigemCSVITAU.Location = new System.Drawing.Point(448, 37);
            this.btnOrigemCSVITAU.Name = "btnOrigemCSVITAU";
            this.btnOrigemCSVITAU.Size = new System.Drawing.Size(26, 22);
            this.btnOrigemCSVITAU.TabIndex = 5;
            this.btnOrigemCSVITAU.Text = "...";
            this.btnOrigemCSVITAU.UseVisualStyleBackColor = true;
            this.btnOrigemCSVITAU.Click += new System.EventHandler(this.btnOrigemCSVITAU_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destino do arquivo processado";
            // 
            // tbDestinoCSVItau
            // 
            this.tbDestinoCSVItau.Location = new System.Drawing.Point(10, 79);
            this.tbDestinoCSVItau.Name = "tbDestinoCSVItau";
            this.tbDestinoCSVItau.Size = new System.Drawing.Size(438, 20);
            this.tbDestinoCSVItau.TabIndex = 8;
            // 
            // btnDestinoCSVITAU
            // 
            this.btnDestinoCSVITAU.Location = new System.Drawing.Point(449, 78);
            this.btnDestinoCSVITAU.Name = "btnDestinoCSVITAU";
            this.btnDestinoCSVITAU.Size = new System.Drawing.Size(26, 22);
            this.btnDestinoCSVITAU.TabIndex = 9;
            this.btnDestinoCSVITAU.Text = "...";
            this.btnDestinoCSVITAU.UseVisualStyleBackColor = true;
            this.btnDestinoCSVITAU.Click += new System.EventHandler(this.btnDestinoCSVITAU_Click);
            // 
            // btnLerCSVItau
            // 
            this.btnLerCSVItau.Location = new System.Drawing.Point(494, 38);
            this.btnLerCSVItau.Name = "btnLerCSVItau";
            this.btnLerCSVItau.Size = new System.Drawing.Size(159, 21);
            this.btnLerCSVItau.TabIndex = 1;
            this.btnLerCSVItau.Text = "Ler Arquivo";
            this.btnLerCSVItau.UseVisualStyleBackColor = true;
            this.btnLerCSVItau.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalvarConfiguracoesITAU
            // 
            this.btnSalvarConfiguracoesITAU.Location = new System.Drawing.Point(494, 78);
            this.btnSalvarConfiguracoesITAU.Name = "btnSalvarConfiguracoesITAU";
            this.btnSalvarConfiguracoesITAU.Size = new System.Drawing.Size(159, 22);
            this.btnSalvarConfiguracoesITAU.TabIndex = 16;
            this.btnSalvarConfiguracoesITAU.Text = "Salvar Configurações";
            this.btnSalvarConfiguracoesITAU.UseVisualStyleBackColor = true;
            this.btnSalvarConfiguracoesITAU.Click += new System.EventHandler(this.btnSalvarConfiguracoesITAU_Click);
            // 
            // pbLeituraDRItau
            // 
            this.pbLeituraDRItau.Location = new System.Drawing.Point(494, 37);
            this.pbLeituraDRItau.Name = "pbLeituraDRItau";
            this.pbLeituraDRItau.Size = new System.Drawing.Size(159, 21);
            this.pbLeituraDRItau.TabIndex = 15;
            this.pbLeituraDRItau.Visible = false;
            // 
            // gbDockTech
            // 
            this.gbDockTech.Controls.Add(this.pbLeituraDRDockTech);
            this.gbDockTech.Controls.Add(this.btnSalvarConfiguracoesDOCKTECH);
            this.gbDockTech.Controls.Add(this.btnLerCSVDockTech);
            this.gbDockTech.Controls.Add(this.btnDestinoCSVDockTech);
            this.gbDockTech.Controls.Add(this.tbDestinoCSVDockTech);
            this.gbDockTech.Controls.Add(this.label27);
            this.gbDockTech.Controls.Add(this.btnOrigemCSVDockTech);
            this.gbDockTech.Controls.Add(this.tbOrigemCSVDockTech);
            this.gbDockTech.Controls.Add(this.label28);
            this.gbDockTech.Location = new System.Drawing.Point(312, 241);
            this.gbDockTech.Name = "gbDockTech";
            this.gbDockTech.Size = new System.Drawing.Size(663, 113);
            this.gbDockTech.TabIndex = 14;
            this.gbDockTech.TabStop = false;
            this.gbDockTech.Text = "DOCK TECH";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 23);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 13);
            this.label28.TabIndex = 1;
            this.label28.Text = "Origem do CSV";
            // 
            // tbOrigemCSVDockTech
            // 
            this.tbOrigemCSVDockTech.Location = new System.Drawing.Point(9, 38);
            this.tbOrigemCSVDockTech.Name = "tbOrigemCSVDockTech";
            this.tbOrigemCSVDockTech.Size = new System.Drawing.Size(438, 20);
            this.tbOrigemCSVDockTech.TabIndex = 3;
            // 
            // btnOrigemCSVDockTech
            // 
            this.btnOrigemCSVDockTech.Location = new System.Drawing.Point(448, 37);
            this.btnOrigemCSVDockTech.Name = "btnOrigemCSVDockTech";
            this.btnOrigemCSVDockTech.Size = new System.Drawing.Size(26, 22);
            this.btnOrigemCSVDockTech.TabIndex = 5;
            this.btnOrigemCSVDockTech.Text = "...";
            this.btnOrigemCSVDockTech.UseVisualStyleBackColor = true;
            this.btnOrigemCSVDockTech.Click += new System.EventHandler(this.btnOrigemCSVDockTech_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 64);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(154, 13);
            this.label27.TabIndex = 7;
            this.label27.Text = "Destino do arquivo processado";
            // 
            // tbDestinoCSVDockTech
            // 
            this.tbDestinoCSVDockTech.Location = new System.Drawing.Point(10, 79);
            this.tbDestinoCSVDockTech.Name = "tbDestinoCSVDockTech";
            this.tbDestinoCSVDockTech.Size = new System.Drawing.Size(438, 20);
            this.tbDestinoCSVDockTech.TabIndex = 8;
            // 
            // btnDestinoCSVDockTech
            // 
            this.btnDestinoCSVDockTech.Location = new System.Drawing.Point(449, 78);
            this.btnDestinoCSVDockTech.Name = "btnDestinoCSVDockTech";
            this.btnDestinoCSVDockTech.Size = new System.Drawing.Size(26, 22);
            this.btnDestinoCSVDockTech.TabIndex = 9;
            this.btnDestinoCSVDockTech.Text = "...";
            this.btnDestinoCSVDockTech.UseVisualStyleBackColor = true;
            this.btnDestinoCSVDockTech.Click += new System.EventHandler(this.btnDestinoCSVDockTech_Click);
            // 
            // btnLerCSVDockTech
            // 
            this.btnLerCSVDockTech.Location = new System.Drawing.Point(494, 38);
            this.btnLerCSVDockTech.Name = "btnLerCSVDockTech";
            this.btnLerCSVDockTech.Size = new System.Drawing.Size(159, 21);
            this.btnLerCSVDockTech.TabIndex = 1;
            this.btnLerCSVDockTech.Text = "Ler Arquivo";
            this.btnLerCSVDockTech.UseVisualStyleBackColor = true;
            this.btnLerCSVDockTech.Click += new System.EventHandler(this.btnLerCSVDockTech_Click);
            // 
            // btnSalvarConfiguracoesDOCKTECH
            // 
            this.btnSalvarConfiguracoesDOCKTECH.Location = new System.Drawing.Point(494, 78);
            this.btnSalvarConfiguracoesDOCKTECH.Name = "btnSalvarConfiguracoesDOCKTECH";
            this.btnSalvarConfiguracoesDOCKTECH.Size = new System.Drawing.Size(159, 22);
            this.btnSalvarConfiguracoesDOCKTECH.TabIndex = 16;
            this.btnSalvarConfiguracoesDOCKTECH.Text = "Salvar Configurações";
            this.btnSalvarConfiguracoesDOCKTECH.UseVisualStyleBackColor = true;
            this.btnSalvarConfiguracoesDOCKTECH.Click += new System.EventHandler(this.btnSalvarConfiguracoesDOCKTECH_Click);
            // 
            // pbLeituraDRDockTech
            // 
            this.pbLeituraDRDockTech.Location = new System.Drawing.Point(494, 37);
            this.pbLeituraDRDockTech.Name = "pbLeituraDRDockTech";
            this.pbLeituraDRDockTech.Size = new System.Drawing.Size(159, 21);
            this.pbLeituraDRDockTech.TabIndex = 15;
            this.pbLeituraDRDockTech.Visible = false;
            // 
            // gbBMG
            // 
            this.gbBMG.Controls.Add(this.pbLeituraDRBMG);
            this.gbBMG.Controls.Add(this.btnSalvarConfiguracoesBMG);
            this.gbBMG.Controls.Add(this.btnLerCSVBMG);
            this.gbBMG.Controls.Add(this.btnDestinoCSVBMG);
            this.gbBMG.Controls.Add(this.tbDestinoCSVBMG);
            this.gbBMG.Controls.Add(this.label29);
            this.gbBMG.Controls.Add(this.btnOrigemCSVBMG);
            this.gbBMG.Controls.Add(this.tbOrigemCSVBMG);
            this.gbBMG.Controls.Add(this.label30);
            this.gbBMG.Location = new System.Drawing.Point(312, 360);
            this.gbBMG.Name = "gbBMG";
            this.gbBMG.Size = new System.Drawing.Size(663, 113);
            this.gbBMG.TabIndex = 15;
            this.gbBMG.TabStop = false;
            this.gbBMG.Text = "BMG";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 23);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 13);
            this.label30.TabIndex = 1;
            this.label30.Text = "Origem do CSV";
            // 
            // tbOrigemCSVBMG
            // 
            this.tbOrigemCSVBMG.Location = new System.Drawing.Point(9, 38);
            this.tbOrigemCSVBMG.Name = "tbOrigemCSVBMG";
            this.tbOrigemCSVBMG.Size = new System.Drawing.Size(438, 20);
            this.tbOrigemCSVBMG.TabIndex = 3;
            // 
            // btnOrigemCSVBMG
            // 
            this.btnOrigemCSVBMG.Location = new System.Drawing.Point(448, 37);
            this.btnOrigemCSVBMG.Name = "btnOrigemCSVBMG";
            this.btnOrigemCSVBMG.Size = new System.Drawing.Size(26, 22);
            this.btnOrigemCSVBMG.TabIndex = 5;
            this.btnOrigemCSVBMG.Text = "...";
            this.btnOrigemCSVBMG.UseVisualStyleBackColor = true;
            this.btnOrigemCSVBMG.Click += new System.EventHandler(this.btnOrigemCSVBMG_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 64);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(154, 13);
            this.label29.TabIndex = 7;
            this.label29.Text = "Destino do arquivo processado";
            // 
            // tbDestinoCSVBMG
            // 
            this.tbDestinoCSVBMG.Location = new System.Drawing.Point(10, 79);
            this.tbDestinoCSVBMG.Name = "tbDestinoCSVBMG";
            this.tbDestinoCSVBMG.Size = new System.Drawing.Size(438, 20);
            this.tbDestinoCSVBMG.TabIndex = 8;
            // 
            // btnDestinoCSVBMG
            // 
            this.btnDestinoCSVBMG.Location = new System.Drawing.Point(449, 78);
            this.btnDestinoCSVBMG.Name = "btnDestinoCSVBMG";
            this.btnDestinoCSVBMG.Size = new System.Drawing.Size(26, 22);
            this.btnDestinoCSVBMG.TabIndex = 9;
            this.btnDestinoCSVBMG.Text = "...";
            this.btnDestinoCSVBMG.UseVisualStyleBackColor = true;
            this.btnDestinoCSVBMG.Click += new System.EventHandler(this.btnDestinoCSVBMG_Click);
            // 
            // btnLerCSVBMG
            // 
            this.btnLerCSVBMG.Location = new System.Drawing.Point(494, 38);
            this.btnLerCSVBMG.Name = "btnLerCSVBMG";
            this.btnLerCSVBMG.Size = new System.Drawing.Size(159, 21);
            this.btnLerCSVBMG.TabIndex = 1;
            this.btnLerCSVBMG.Text = "Ler Arquivo";
            this.btnLerCSVBMG.UseVisualStyleBackColor = true;
            this.btnLerCSVBMG.Click += new System.EventHandler(this.btnLerCSVBMG_Click);
            // 
            // btnSalvarConfiguracoesBMG
            // 
            this.btnSalvarConfiguracoesBMG.Location = new System.Drawing.Point(494, 78);
            this.btnSalvarConfiguracoesBMG.Name = "btnSalvarConfiguracoesBMG";
            this.btnSalvarConfiguracoesBMG.Size = new System.Drawing.Size(159, 22);
            this.btnSalvarConfiguracoesBMG.TabIndex = 16;
            this.btnSalvarConfiguracoesBMG.Text = "Salvar Configurações";
            this.btnSalvarConfiguracoesBMG.UseVisualStyleBackColor = true;
            this.btnSalvarConfiguracoesBMG.Click += new System.EventHandler(this.btnSalvarConfiguracoesBMG_Click);
            // 
            // pbLeituraDRBMG
            // 
            this.pbLeituraDRBMG.Location = new System.Drawing.Point(494, 37);
            this.pbLeituraDRBMG.Name = "pbLeituraDRBMG";
            this.pbLeituraDRBMG.Size = new System.Drawing.Size(159, 21);
            this.pbLeituraDRBMG.TabIndex = 15;
            this.pbLeituraDRBMG.Visible = false;
            // 
            // tabRajadas
            // 
            this.tabRajadas.BackColor = System.Drawing.Color.Transparent;
            this.tabRajadas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabRajadas.BackgroundImage")));
            this.tabRajadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabRajadas.Controls.Add(this.groupBox5);
            this.tabRajadas.Location = new System.Drawing.Point(4, 22);
            this.tabRajadas.Name = "tabRajadas";
            this.tabRajadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabRajadas.Size = new System.Drawing.Size(997, 481);
            this.tabRajadas.TabIndex = 0;
            this.tabRajadas.Text = "Rajadas";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Location = new System.Drawing.Point(9, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(979, 468);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Configurações";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbMonitoramentoTijolo);
            this.groupBox1.Controls.Add(this.pbLeituraTijolo);
            this.groupBox1.Controls.Add(this.btLerArquivoTijolo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btCaminhoRajadaProcessadaTijolo);
            this.groupBox1.Controls.Add(this.tbCaminhoRajadaProcessadaTijolo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btCaminhoRajadaTijolo);
            this.groupBox1.Controls.Add(this.tbCaminhoRajadaTijolo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Location = new System.Drawing.Point(7, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 140);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rajada Tijolo";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbStatusLeituraTijolo);
            this.groupBox8.Controls.Add(this.btSalvarArquivoTijolo);
            this.groupBox8.Controls.Add(this.lbStatusLeituraTijolo);
            this.groupBox8.Controls.Add(this.cbFrequenciaRajadaTijolo);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.tbIntervaloRajadaTijolo);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Location = new System.Drawing.Point(377, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(315, 120);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Configuração da Leitura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Intervalo";
            // 
            // tbIntervaloRajadaTijolo
            // 
            this.tbIntervaloRajadaTijolo.Location = new System.Drawing.Point(8, 87);
            this.tbIntervaloRajadaTijolo.Name = "tbIntervaloRajadaTijolo";
            this.tbIntervaloRajadaTijolo.Size = new System.Drawing.Size(31, 20);
            this.tbIntervaloRajadaTijolo.TabIndex = 4;
            this.tbIntervaloRajadaTijolo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIntervaloRajadaTijolo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Frequência";
            // 
            // cbFrequenciaRajadaTijolo
            // 
            this.cbFrequenciaRajadaTijolo.DisplayMember = "Segundo";
            this.cbFrequenciaRajadaTijolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrequenciaRajadaTijolo.FormattingEnabled = true;
            this.cbFrequenciaRajadaTijolo.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.cbFrequenciaRajadaTijolo.Location = new System.Drawing.Point(61, 86);
            this.cbFrequenciaRajadaTijolo.Name = "cbFrequenciaRajadaTijolo";
            this.cbFrequenciaRajadaTijolo.Size = new System.Drawing.Size(73, 21);
            this.cbFrequenciaRajadaTijolo.TabIndex = 6;
            // 
            // lbStatusLeituraTijolo
            // 
            this.lbStatusLeituraTijolo.AutoSize = true;
            this.lbStatusLeituraTijolo.Location = new System.Drawing.Point(6, 24);
            this.lbStatusLeituraTijolo.Name = "lbStatusLeituraTijolo";
            this.lbStatusLeituraTijolo.Size = new System.Drawing.Size(94, 13);
            this.lbStatusLeituraTijolo.TabIndex = 7;
            this.lbStatusLeituraTijolo.Text = "Leitura automática";
            // 
            // btSalvarArquivoTijolo
            // 
            this.btSalvarArquivoTijolo.Location = new System.Drawing.Point(148, 93);
            this.btSalvarArquivoTijolo.Name = "btSalvarArquivoTijolo";
            this.btSalvarArquivoTijolo.Size = new System.Drawing.Size(159, 21);
            this.btSalvarArquivoTijolo.TabIndex = 16;
            this.btSalvarArquivoTijolo.Text = "Salvar Configurações";
            this.btSalvarArquivoTijolo.UseVisualStyleBackColor = true;
            this.btSalvarArquivoTijolo.Click += new System.EventHandler(this.btSalvarArquivoTijolo_Click);
            // 
            // cbStatusLeituraTijolo
            // 
            this.cbStatusLeituraTijolo.DisplayMember = "Segundo";
            this.cbStatusLeituraTijolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusLeituraTijolo.FormattingEnabled = true;
            this.cbStatusLeituraTijolo.Items.AddRange(new object[] {
            "Ativada",
            "Desativada"});
            this.cbStatusLeituraTijolo.Location = new System.Drawing.Point(9, 39);
            this.cbStatusLeituraTijolo.Name = "cbStatusLeituraTijolo";
            this.cbStatusLeituraTijolo.Size = new System.Drawing.Size(125, 21);
            this.cbStatusLeituraTijolo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origem das rajadas";
            // 
            // tbCaminhoRajadaTijolo
            // 
            this.tbCaminhoRajadaTijolo.Location = new System.Drawing.Point(7, 45);
            this.tbCaminhoRajadaTijolo.Name = "tbCaminhoRajadaTijolo";
            this.tbCaminhoRajadaTijolo.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaTijolo.TabIndex = 3;
            // 
            // btCaminhoRajadaTijolo
            // 
            this.btCaminhoRajadaTijolo.Location = new System.Drawing.Point(336, 44);
            this.btCaminhoRajadaTijolo.Name = "btCaminhoRajadaTijolo";
            this.btCaminhoRajadaTijolo.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaTijolo.TabIndex = 5;
            this.btCaminhoRajadaTijolo.Text = "...";
            this.btCaminhoRajadaTijolo.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaTijolo.Click += new System.EventHandler(this.botaoApontaCaminhoRajada_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destino das rajadas processadas";
            // 
            // tbCaminhoRajadaProcessadaTijolo
            // 
            this.tbCaminhoRajadaProcessadaTijolo.Location = new System.Drawing.Point(8, 89);
            this.tbCaminhoRajadaProcessadaTijolo.Name = "tbCaminhoRajadaProcessadaTijolo";
            this.tbCaminhoRajadaProcessadaTijolo.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaProcessadaTijolo.TabIndex = 8;
            // 
            // btCaminhoRajadaProcessadaTijolo
            // 
            this.btCaminhoRajadaProcessadaTijolo.Location = new System.Drawing.Point(337, 88);
            this.btCaminhoRajadaProcessadaTijolo.Name = "btCaminhoRajadaProcessadaTijolo";
            this.btCaminhoRajadaProcessadaTijolo.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaProcessadaTijolo.TabIndex = 9;
            this.btCaminhoRajadaProcessadaTijolo.Text = "...";
            this.btCaminhoRajadaProcessadaTijolo.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaProcessadaTijolo.Click += new System.EventHandler(this.btCaminhoRajadaProcessada_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCopiarArquivoProcessadoRajadaTijolo);
            this.groupBox2.Controls.Add(this.rbMoverArquivoProcessadoRajadaTijolo);
            this.groupBox2.Location = new System.Drawing.Point(525, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 55);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuração Arquivo TXT";
            // 
            // rbMoverArquivoProcessadoRajadaTijolo
            // 
            this.rbMoverArquivoProcessadoRajadaTijolo.AutoSize = true;
            this.rbMoverArquivoProcessadoRajadaTijolo.Location = new System.Drawing.Point(6, 32);
            this.rbMoverArquivoProcessadoRajadaTijolo.Name = "rbMoverArquivoProcessadoRajadaTijolo";
            this.rbMoverArquivoProcessadoRajadaTijolo.Size = new System.Drawing.Size(153, 17);
            this.rbMoverArquivoProcessadoRajadaTijolo.TabIndex = 12;
            this.rbMoverArquivoProcessadoRajadaTijolo.Text = "Mover Arquivo Processado";
            this.rbMoverArquivoProcessadoRajadaTijolo.UseVisualStyleBackColor = true;
            this.rbMoverArquivoProcessadoRajadaTijolo.CheckedChanged += new System.EventHandler(this.rbMoverArquivoProcessadoRajadaTijolo_CheckedChanged);
            // 
            // rbCopiarArquivoProcessadoRajadaTijolo
            // 
            this.rbCopiarArquivoProcessadoRajadaTijolo.AutoSize = true;
            this.rbCopiarArquivoProcessadoRajadaTijolo.Location = new System.Drawing.Point(6, 14);
            this.rbCopiarArquivoProcessadoRajadaTijolo.Name = "rbCopiarArquivoProcessadoRajadaTijolo";
            this.rbCopiarArquivoProcessadoRajadaTijolo.Size = new System.Drawing.Size(153, 17);
            this.rbCopiarArquivoProcessadoRajadaTijolo.TabIndex = 11;
            this.rbCopiarArquivoProcessadoRajadaTijolo.Text = "Copiar Arquivo Processado";
            this.rbCopiarArquivoProcessadoRajadaTijolo.UseVisualStyleBackColor = true;
            this.rbCopiarArquivoProcessadoRajadaTijolo.CheckedChanged += new System.EventHandler(this.rbCopiarArquivoProcessadoRajadaTijolo_CheckedChanged);
            // 
            // btLerArquivoTijolo
            // 
            this.btLerArquivoTijolo.Location = new System.Drawing.Point(525, 80);
            this.btLerArquivoTijolo.Name = "btLerArquivoTijolo";
            this.btLerArquivoTijolo.Size = new System.Drawing.Size(159, 21);
            this.btLerArquivoTijolo.TabIndex = 1;
            this.btLerArquivoTijolo.Text = "Ler Arquivo";
            this.btLerArquivoTijolo.UseVisualStyleBackColor = true;
            this.btLerArquivoTijolo.Click += new System.EventHandler(this.btLerArquivoTijolo_Click);
            // 
            // pbLeituraTijolo
            // 
            this.pbLeituraTijolo.Location = new System.Drawing.Point(525, 80);
            this.pbLeituraTijolo.Name = "pbLeituraTijolo";
            this.pbLeituraTijolo.Size = new System.Drawing.Size(159, 21);
            this.pbLeituraTijolo.TabIndex = 15;
            this.pbLeituraTijolo.Visible = false;
            // 
            // gbMonitoramentoTijolo
            // 
            this.gbMonitoramentoTijolo.Controls.Add(this.btAgendamentoTijolo);
            this.gbMonitoramentoTijolo.Controls.Add(this.tbDestinatariosTijolo);
            this.gbMonitoramentoTijolo.Controls.Add(this.label20);
            this.gbMonitoramentoTijolo.Controls.Add(this.cbStatusMonitoramentoTijolo);
            this.gbMonitoramentoTijolo.Controls.Add(this.label17);
            this.gbMonitoramentoTijolo.Location = new System.Drawing.Point(701, 12);
            this.gbMonitoramentoTijolo.Name = "gbMonitoramentoTijolo";
            this.gbMonitoramentoTijolo.Size = new System.Drawing.Size(255, 120);
            this.gbMonitoramentoTijolo.TabIndex = 15;
            this.gbMonitoramentoTijolo.TabStop = false;
            this.gbMonitoramentoTijolo.Text = "Configuração do Monitoramento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Status";
            // 
            // cbStatusMonitoramentoTijolo
            // 
            this.cbStatusMonitoramentoTijolo.DisplayMember = "Segundo";
            this.cbStatusMonitoramentoTijolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusMonitoramentoTijolo.FormattingEnabled = true;
            this.cbStatusMonitoramentoTijolo.Items.AddRange(new object[] {
            "Ativado",
            "Desativado"});
            this.cbStatusMonitoramentoTijolo.Location = new System.Drawing.Point(9, 39);
            this.cbStatusMonitoramentoTijolo.Name = "cbStatusMonitoramentoTijolo";
            this.cbStatusMonitoramentoTijolo.Size = new System.Drawing.Size(91, 21);
            this.cbStatusMonitoramentoTijolo.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Destinatários";
            // 
            // tbDestinatariosTijolo
            // 
            this.tbDestinatariosTijolo.Location = new System.Drawing.Point(8, 87);
            this.tbDestinatariosTijolo.Name = "tbDestinatariosTijolo";
            this.tbDestinatariosTijolo.Size = new System.Drawing.Size(237, 20);
            this.tbDestinatariosTijolo.TabIndex = 10;
            // 
            // btAgendamentoTijolo
            // 
            this.btAgendamentoTijolo.Location = new System.Drawing.Point(110, 39);
            this.btAgendamentoTijolo.Name = "btAgendamentoTijolo";
            this.btAgendamentoTijolo.Size = new System.Drawing.Size(135, 21);
            this.btAgendamentoTijolo.TabIndex = 17;
            this.btAgendamentoTijolo.Text = "Agendamento";
            this.btAgendamentoTijolo.UseVisualStyleBackColor = true;
            this.btAgendamentoTijolo.Click += new System.EventHandler(this.btAgendamentoTijolo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbMonitoramentoDigital);
            this.groupBox3.Controls.Add(this.pbLeituraDigital);
            this.groupBox3.Controls.Add(this.btLerArquivoDigital);
            this.groupBox3.Controls.Add(this.btSalvarArquivoDigital);
            this.groupBox3.Controls.Add(this.btCaminhoRajadaProcessadaDigital);
            this.groupBox3.Controls.Add(this.tbCaminhoRajadaProcessadaDigital);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btCaminhoRajadaDigital);
            this.groupBox3.Controls.Add(this.tbCaminhoRajadaDigital);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.Location = new System.Drawing.Point(7, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(964, 140);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rajada Digital";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cbStatusLeituraDigital);
            this.groupBox9.Controls.Add(this.lbStatusLeituraDigital);
            this.groupBox9.Controls.Add(this.cbFrequenciaRajadaDigital);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.groupBox6);
            this.groupBox9.Controls.Add(this.tbIntervaloRajadaDigital);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Location = new System.Drawing.Point(376, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(315, 120);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Configuração da Leitura";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Intervalo";
            // 
            // tbIntervaloRajadaDigital
            // 
            this.tbIntervaloRajadaDigital.Location = new System.Drawing.Point(8, 87);
            this.tbIntervaloRajadaDigital.Name = "tbIntervaloRajadaDigital";
            this.tbIntervaloRajadaDigital.Size = new System.Drawing.Size(31, 20);
            this.tbIntervaloRajadaDigital.TabIndex = 4;
            this.tbIntervaloRajadaDigital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIntervaloRajadaDigital_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbCopiarArquivoProcessadoRajadaDigital);
            this.groupBox6.Controls.Add(this.rbMoverArquivoProcessadoRajadaDigital);
            this.groupBox6.Location = new System.Drawing.Point(148, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(160, 55);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Configuração Arquivo TXT";
            // 
            // rbMoverArquivoProcessadoRajadaDigital
            // 
            this.rbMoverArquivoProcessadoRajadaDigital.AutoSize = true;
            this.rbMoverArquivoProcessadoRajadaDigital.Location = new System.Drawing.Point(6, 32);
            this.rbMoverArquivoProcessadoRajadaDigital.Name = "rbMoverArquivoProcessadoRajadaDigital";
            this.rbMoverArquivoProcessadoRajadaDigital.Size = new System.Drawing.Size(153, 17);
            this.rbMoverArquivoProcessadoRajadaDigital.TabIndex = 12;
            this.rbMoverArquivoProcessadoRajadaDigital.Text = "Mover Arquivo Processado";
            this.rbMoverArquivoProcessadoRajadaDigital.UseVisualStyleBackColor = true;
            // 
            // rbCopiarArquivoProcessadoRajadaDigital
            // 
            this.rbCopiarArquivoProcessadoRajadaDigital.AutoSize = true;
            this.rbCopiarArquivoProcessadoRajadaDigital.Location = new System.Drawing.Point(6, 14);
            this.rbCopiarArquivoProcessadoRajadaDigital.Name = "rbCopiarArquivoProcessadoRajadaDigital";
            this.rbCopiarArquivoProcessadoRajadaDigital.Size = new System.Drawing.Size(153, 17);
            this.rbCopiarArquivoProcessadoRajadaDigital.TabIndex = 11;
            this.rbCopiarArquivoProcessadoRajadaDigital.Text = "Copiar Arquivo Processado";
            this.rbCopiarArquivoProcessadoRajadaDigital.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Frequência";
            // 
            // cbFrequenciaRajadaDigital
            // 
            this.cbFrequenciaRajadaDigital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrequenciaRajadaDigital.FormattingEnabled = true;
            this.cbFrequenciaRajadaDigital.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.cbFrequenciaRajadaDigital.Location = new System.Drawing.Point(61, 87);
            this.cbFrequenciaRajadaDigital.Name = "cbFrequenciaRajadaDigital";
            this.cbFrequenciaRajadaDigital.Size = new System.Drawing.Size(73, 21);
            this.cbFrequenciaRajadaDigital.TabIndex = 6;
            // 
            // lbStatusLeituraDigital
            // 
            this.lbStatusLeituraDigital.AutoSize = true;
            this.lbStatusLeituraDigital.Location = new System.Drawing.Point(6, 24);
            this.lbStatusLeituraDigital.Name = "lbStatusLeituraDigital";
            this.lbStatusLeituraDigital.Size = new System.Drawing.Size(94, 13);
            this.lbStatusLeituraDigital.TabIndex = 9;
            this.lbStatusLeituraDigital.Text = "Leitura automática";
            // 
            // cbStatusLeituraDigital
            // 
            this.cbStatusLeituraDigital.DisplayMember = "Segundo";
            this.cbStatusLeituraDigital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusLeituraDigital.FormattingEnabled = true;
            this.cbStatusLeituraDigital.Items.AddRange(new object[] {
            "Ativada",
            "Desativada"});
            this.cbStatusLeituraDigital.Location = new System.Drawing.Point(9, 39);
            this.cbStatusLeituraDigital.Name = "cbStatusLeituraDigital";
            this.cbStatusLeituraDigital.Size = new System.Drawing.Size(125, 21);
            this.cbStatusLeituraDigital.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Origem das rajadas";
            // 
            // tbCaminhoRajadaDigital
            // 
            this.tbCaminhoRajadaDigital.Location = new System.Drawing.Point(7, 45);
            this.tbCaminhoRajadaDigital.Name = "tbCaminhoRajadaDigital";
            this.tbCaminhoRajadaDigital.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaDigital.TabIndex = 3;
            // 
            // btCaminhoRajadaDigital
            // 
            this.btCaminhoRajadaDigital.Location = new System.Drawing.Point(336, 44);
            this.btCaminhoRajadaDigital.Name = "btCaminhoRajadaDigital";
            this.btCaminhoRajadaDigital.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaDigital.TabIndex = 5;
            this.btCaminhoRajadaDigital.Text = "...";
            this.btCaminhoRajadaDigital.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaDigital.Click += new System.EventHandler(this.btCaminhoRajadaDigital_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destino das rajadas processadas";
            // 
            // tbCaminhoRajadaProcessadaDigital
            // 
            this.tbCaminhoRajadaProcessadaDigital.Location = new System.Drawing.Point(7, 89);
            this.tbCaminhoRajadaProcessadaDigital.Name = "tbCaminhoRajadaProcessadaDigital";
            this.tbCaminhoRajadaProcessadaDigital.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaProcessadaDigital.TabIndex = 8;
            // 
            // btCaminhoRajadaProcessadaDigital
            // 
            this.btCaminhoRajadaProcessadaDigital.Location = new System.Drawing.Point(336, 88);
            this.btCaminhoRajadaProcessadaDigital.Name = "btCaminhoRajadaProcessadaDigital";
            this.btCaminhoRajadaProcessadaDigital.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaProcessadaDigital.TabIndex = 9;
            this.btCaminhoRajadaProcessadaDigital.Text = "...";
            this.btCaminhoRajadaProcessadaDigital.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaProcessadaDigital.Click += new System.EventHandler(this.btCaminhoRajadaProcessadaDigital_Click);
            // 
            // btSalvarArquivoDigital
            // 
            this.btSalvarArquivoDigital.Location = new System.Drawing.Point(525, 105);
            this.btSalvarArquivoDigital.Name = "btSalvarArquivoDigital";
            this.btSalvarArquivoDigital.Size = new System.Drawing.Size(159, 21);
            this.btSalvarArquivoDigital.TabIndex = 18;
            this.btSalvarArquivoDigital.Text = "Salvar Configurações";
            this.btSalvarArquivoDigital.UseVisualStyleBackColor = true;
            this.btSalvarArquivoDigital.Click += new System.EventHandler(this.btSalvarArquivoDigital_Click);
            // 
            // btLerArquivoDigital
            // 
            this.btLerArquivoDigital.Location = new System.Drawing.Point(525, 80);
            this.btLerArquivoDigital.Name = "btLerArquivoDigital";
            this.btLerArquivoDigital.Size = new System.Drawing.Size(159, 21);
            this.btLerArquivoDigital.TabIndex = 19;
            this.btLerArquivoDigital.Text = "Ler Arquivo";
            this.btLerArquivoDigital.UseVisualStyleBackColor = true;
            this.btLerArquivoDigital.Click += new System.EventHandler(this.btLerArquivoDigital_Click);
            // 
            // pbLeituraDigital
            // 
            this.pbLeituraDigital.Location = new System.Drawing.Point(525, 80);
            this.pbLeituraDigital.Name = "pbLeituraDigital";
            this.pbLeituraDigital.Size = new System.Drawing.Size(159, 21);
            this.pbLeituraDigital.TabIndex = 20;
            this.pbLeituraDigital.Visible = false;
            // 
            // gbMonitoramentoDigital
            // 
            this.gbMonitoramentoDigital.Controls.Add(this.btAgendamentoDigital);
            this.gbMonitoramentoDigital.Controls.Add(this.tbDestinatariosDigital);
            this.gbMonitoramentoDigital.Controls.Add(this.label21);
            this.gbMonitoramentoDigital.Controls.Add(this.cbStatusMonitoramentoDigital);
            this.gbMonitoramentoDigital.Controls.Add(this.label22);
            this.gbMonitoramentoDigital.Location = new System.Drawing.Point(701, 12);
            this.gbMonitoramentoDigital.Name = "gbMonitoramentoDigital";
            this.gbMonitoramentoDigital.Size = new System.Drawing.Size(255, 120);
            this.gbMonitoramentoDigital.TabIndex = 21;
            this.gbMonitoramentoDigital.TabStop = false;
            this.gbMonitoramentoDigital.Text = "Configuração do Monitoramento";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Status";
            // 
            // cbStatusMonitoramentoDigital
            // 
            this.cbStatusMonitoramentoDigital.DisplayMember = "Segundo";
            this.cbStatusMonitoramentoDigital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusMonitoramentoDigital.FormattingEnabled = true;
            this.cbStatusMonitoramentoDigital.Items.AddRange(new object[] {
            "Ativado",
            "Desativado"});
            this.cbStatusMonitoramentoDigital.Location = new System.Drawing.Point(9, 39);
            this.cbStatusMonitoramentoDigital.Name = "cbStatusMonitoramentoDigital";
            this.cbStatusMonitoramentoDigital.Size = new System.Drawing.Size(91, 21);
            this.cbStatusMonitoramentoDigital.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Destinatários";
            // 
            // tbDestinatariosDigital
            // 
            this.tbDestinatariosDigital.Location = new System.Drawing.Point(9, 87);
            this.tbDestinatariosDigital.Name = "tbDestinatariosDigital";
            this.tbDestinatariosDigital.Size = new System.Drawing.Size(237, 20);
            this.tbDestinatariosDigital.TabIndex = 10;
            // 
            // btAgendamentoDigital
            // 
            this.btAgendamentoDigital.Location = new System.Drawing.Point(110, 39);
            this.btAgendamentoDigital.Name = "btAgendamentoDigital";
            this.btAgendamentoDigital.Size = new System.Drawing.Size(135, 21);
            this.btAgendamentoDigital.TabIndex = 18;
            this.btAgendamentoDigital.Text = "Agendamento";
            this.btAgendamentoDigital.UseVisualStyleBackColor = true;
            this.btAgendamentoDigital.Click += new System.EventHandler(this.btAgendamentoDigital_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gbMonitoramentoInvertida);
            this.groupBox4.Controls.Add(this.pbLeituraInvertida);
            this.groupBox4.Controls.Add(this.btLerArquivoInvertida);
            this.groupBox4.Controls.Add(this.btSalvarArquivoInvertida);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.btCaminhoRajadaProcessadaTrintaTrinta);
            this.groupBox4.Controls.Add(this.tbCaminhoRajadaProcessadaInvertida);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btApontaCaminhoRajadaTrintaTrinta);
            this.groupBox4.Controls.Add(this.tbCaminhoRajadaInvertida);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.groupBox10);
            this.groupBox4.Location = new System.Drawing.Point(7, 315);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(964, 140);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rajada Invertida";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cbStatusLeituraInvertida);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.cbFrequenciaRajadaInvertida);
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Controls.Add(this.tbIntervaloRajadaInvertida);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Location = new System.Drawing.Point(376, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(315, 120);
            this.groupBox10.TabIndex = 16;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Configuração da Leitura";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Intervalo";
            // 
            // tbIntervaloRajadaInvertida
            // 
            this.tbIntervaloRajadaInvertida.Location = new System.Drawing.Point(8, 87);
            this.tbIntervaloRajadaInvertida.Name = "tbIntervaloRajadaInvertida";
            this.tbIntervaloRajadaInvertida.Size = new System.Drawing.Size(31, 20);
            this.tbIntervaloRajadaInvertida.TabIndex = 4;
            this.tbIntervaloRajadaInvertida.TextChanged += new System.EventHandler(this.tbIntervaloRajadaInvertida_TextChanged);
            this.tbIntervaloRajadaInvertida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIntervaloRajadaInvertida_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Frequência";
            // 
            // cbFrequenciaRajadaInvertida
            // 
            this.cbFrequenciaRajadaInvertida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrequenciaRajadaInvertida.FormattingEnabled = true;
            this.cbFrequenciaRajadaInvertida.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.cbFrequenciaRajadaInvertida.Location = new System.Drawing.Point(61, 86);
            this.cbFrequenciaRajadaInvertida.Name = "cbFrequenciaRajadaInvertida";
            this.cbFrequenciaRajadaInvertida.Size = new System.Drawing.Size(73, 21);
            this.cbFrequenciaRajadaInvertida.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Leitura automática";
            // 
            // cbStatusLeituraInvertida
            // 
            this.cbStatusLeituraInvertida.DisplayMember = "Segundo";
            this.cbStatusLeituraInvertida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusLeituraInvertida.FormattingEnabled = true;
            this.cbStatusLeituraInvertida.Items.AddRange(new object[] {
            "Ativada",
            "Desativada"});
            this.cbStatusLeituraInvertida.Location = new System.Drawing.Point(9, 39);
            this.cbStatusLeituraInvertida.Name = "cbStatusLeituraInvertida";
            this.cbStatusLeituraInvertida.Size = new System.Drawing.Size(125, 21);
            this.cbStatusLeituraInvertida.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Origem das rajadas";
            // 
            // tbCaminhoRajadaInvertida
            // 
            this.tbCaminhoRajadaInvertida.Location = new System.Drawing.Point(7, 45);
            this.tbCaminhoRajadaInvertida.Name = "tbCaminhoRajadaInvertida";
            this.tbCaminhoRajadaInvertida.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaInvertida.TabIndex = 3;
            // 
            // btApontaCaminhoRajadaTrintaTrinta
            // 
            this.btApontaCaminhoRajadaTrintaTrinta.Location = new System.Drawing.Point(336, 44);
            this.btApontaCaminhoRajadaTrintaTrinta.Name = "btApontaCaminhoRajadaTrintaTrinta";
            this.btApontaCaminhoRajadaTrintaTrinta.Size = new System.Drawing.Size(26, 22);
            this.btApontaCaminhoRajadaTrintaTrinta.TabIndex = 5;
            this.btApontaCaminhoRajadaTrintaTrinta.Text = "...";
            this.btApontaCaminhoRajadaTrintaTrinta.UseVisualStyleBackColor = true;
            this.btApontaCaminhoRajadaTrintaTrinta.Click += new System.EventHandler(this.btApontaCaminhoRajadaTrintaTrinta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Destino das rajadas processadas";
            // 
            // tbCaminhoRajadaProcessadaInvertida
            // 
            this.tbCaminhoRajadaProcessadaInvertida.Location = new System.Drawing.Point(7, 89);
            this.tbCaminhoRajadaProcessadaInvertida.Name = "tbCaminhoRajadaProcessadaInvertida";
            this.tbCaminhoRajadaProcessadaInvertida.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaProcessadaInvertida.TabIndex = 8;
            // 
            // btCaminhoRajadaProcessadaTrintaTrinta
            // 
            this.btCaminhoRajadaProcessadaTrintaTrinta.Location = new System.Drawing.Point(336, 88);
            this.btCaminhoRajadaProcessadaTrintaTrinta.Name = "btCaminhoRajadaProcessadaTrintaTrinta";
            this.btCaminhoRajadaProcessadaTrintaTrinta.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaProcessadaTrintaTrinta.TabIndex = 9;
            this.btCaminhoRajadaProcessadaTrintaTrinta.Text = "...";
            this.btCaminhoRajadaProcessadaTrintaTrinta.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaProcessadaTrintaTrinta.Click += new System.EventHandler(this.btCaminhoRajadaProcessadaTrintaTrinta_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbCopiarArquivoProcessadoRajadaInvertida);
            this.groupBox7.Controls.Add(this.rbMoverArquivoProcessadoRajadaInvertida);
            this.groupBox7.Location = new System.Drawing.Point(524, 20);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(160, 55);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Configuração Arquivo TXT";
            // 
            // rbMoverArquivoProcessadoRajadaInvertida
            // 
            this.rbMoverArquivoProcessadoRajadaInvertida.AutoSize = true;
            this.rbMoverArquivoProcessadoRajadaInvertida.Location = new System.Drawing.Point(6, 32);
            this.rbMoverArquivoProcessadoRajadaInvertida.Name = "rbMoverArquivoProcessadoRajadaInvertida";
            this.rbMoverArquivoProcessadoRajadaInvertida.Size = new System.Drawing.Size(153, 17);
            this.rbMoverArquivoProcessadoRajadaInvertida.TabIndex = 12;
            this.rbMoverArquivoProcessadoRajadaInvertida.Text = "Mover Arquivo Processado";
            this.rbMoverArquivoProcessadoRajadaInvertida.UseVisualStyleBackColor = true;
            // 
            // rbCopiarArquivoProcessadoRajadaInvertida
            // 
            this.rbCopiarArquivoProcessadoRajadaInvertida.AutoSize = true;
            this.rbCopiarArquivoProcessadoRajadaInvertida.Location = new System.Drawing.Point(6, 14);
            this.rbCopiarArquivoProcessadoRajadaInvertida.Name = "rbCopiarArquivoProcessadoRajadaInvertida";
            this.rbCopiarArquivoProcessadoRajadaInvertida.Size = new System.Drawing.Size(153, 17);
            this.rbCopiarArquivoProcessadoRajadaInvertida.TabIndex = 11;
            this.rbCopiarArquivoProcessadoRajadaInvertida.Text = "Copiar Arquivo Processado";
            this.rbCopiarArquivoProcessadoRajadaInvertida.UseVisualStyleBackColor = true;
            // 
            // btSalvarArquivoInvertida
            // 
            this.btSalvarArquivoInvertida.Location = new System.Drawing.Point(524, 105);
            this.btSalvarArquivoInvertida.Name = "btSalvarArquivoInvertida";
            this.btSalvarArquivoInvertida.Size = new System.Drawing.Size(159, 21);
            this.btSalvarArquivoInvertida.TabIndex = 20;
            this.btSalvarArquivoInvertida.Text = "Salvar Configurações";
            this.btSalvarArquivoInvertida.UseVisualStyleBackColor = true;
            this.btSalvarArquivoInvertida.Click += new System.EventHandler(this.btSalvarArquivoInvertida_Click);
            // 
            // btLerArquivoInvertida
            // 
            this.btLerArquivoInvertida.Location = new System.Drawing.Point(524, 80);
            this.btLerArquivoInvertida.Name = "btLerArquivoInvertida";
            this.btLerArquivoInvertida.Size = new System.Drawing.Size(159, 21);
            this.btLerArquivoInvertida.TabIndex = 21;
            this.btLerArquivoInvertida.Text = "Ler Arquivo";
            this.btLerArquivoInvertida.UseVisualStyleBackColor = true;
            this.btLerArquivoInvertida.Click += new System.EventHandler(this.btLerArquivoInvertida_Click);
            // 
            // pbLeituraInvertida
            // 
            this.pbLeituraInvertida.Location = new System.Drawing.Point(524, 80);
            this.pbLeituraInvertida.Name = "pbLeituraInvertida";
            this.pbLeituraInvertida.Size = new System.Drawing.Size(159, 21);
            this.pbLeituraInvertida.TabIndex = 22;
            this.pbLeituraInvertida.Visible = false;
            // 
            // gbMonitoramentoInvertida
            // 
            this.gbMonitoramentoInvertida.Controls.Add(this.btAgendamentoInvertida);
            this.gbMonitoramentoInvertida.Controls.Add(this.tbDestinatariosInvertida);
            this.gbMonitoramentoInvertida.Controls.Add(this.label25);
            this.gbMonitoramentoInvertida.Controls.Add(this.cbStatusMonitoramentoInvertida);
            this.gbMonitoramentoInvertida.Controls.Add(this.label26);
            this.gbMonitoramentoInvertida.Location = new System.Drawing.Point(701, 12);
            this.gbMonitoramentoInvertida.Name = "gbMonitoramentoInvertida";
            this.gbMonitoramentoInvertida.Size = new System.Drawing.Size(255, 120);
            this.gbMonitoramentoInvertida.TabIndex = 23;
            this.gbMonitoramentoInvertida.TabStop = false;
            this.gbMonitoramentoInvertida.Text = "Configuração do Monitoramento";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 24);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 13);
            this.label26.TabIndex = 7;
            this.label26.Text = "Status";
            // 
            // cbStatusMonitoramentoInvertida
            // 
            this.cbStatusMonitoramentoInvertida.DisplayMember = "Segundo";
            this.cbStatusMonitoramentoInvertida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusMonitoramentoInvertida.FormattingEnabled = true;
            this.cbStatusMonitoramentoInvertida.Items.AddRange(new object[] {
            "Ativado",
            "Desativado"});
            this.cbStatusMonitoramentoInvertida.Location = new System.Drawing.Point(9, 39);
            this.cbStatusMonitoramentoInvertida.Name = "cbStatusMonitoramentoInvertida";
            this.cbStatusMonitoramentoInvertida.Size = new System.Drawing.Size(91, 21);
            this.cbStatusMonitoramentoInvertida.TabIndex = 8;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 72);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 13);
            this.label25.TabIndex = 9;
            this.label25.Text = "Destinatários";
            // 
            // tbDestinatariosInvertida
            // 
            this.tbDestinatariosInvertida.Location = new System.Drawing.Point(8, 87);
            this.tbDestinatariosInvertida.Name = "tbDestinatariosInvertida";
            this.tbDestinatariosInvertida.Size = new System.Drawing.Size(237, 20);
            this.tbDestinatariosInvertida.TabIndex = 10;
            // 
            // btAgendamentoInvertida
            // 
            this.btAgendamentoInvertida.Location = new System.Drawing.Point(111, 39);
            this.btAgendamentoInvertida.Name = "btAgendamentoInvertida";
            this.btAgendamentoInvertida.Size = new System.Drawing.Size(135, 21);
            this.btAgendamentoInvertida.TabIndex = 18;
            this.btAgendamentoInvertida.Text = "Agendamento";
            this.btAgendamentoInvertida.UseVisualStyleBackColor = true;
            this.btAgendamentoInvertida.Click += new System.EventHandler(this.btAgendamentoInvertida_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRajadas);
            this.tabControl1.Controls.Add(this.tabDetalhadoRegistro);
            this.tabControl1.Controls.Add(this.tabDetalhadoProdutividade);
            this.tabControl1.Location = new System.Drawing.Point(5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 507);
            this.tabControl1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 518);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.MinimumSize = new System.Drawing.Size(1002, 519);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BotFlow 2.1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabDetalhadoProdutividade.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabDetalhadoRegistro.ResumeLayout(false);
            this.gbBradesco.ResumeLayout(false);
            this.gbBradesco.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.gbItau.ResumeLayout(false);
            this.gbItau.PerformLayout();
            this.gbDockTech.ResumeLayout(false);
            this.gbDockTech.PerformLayout();
            this.gbBMG.ResumeLayout(false);
            this.gbBMG.PerformLayout();
            this.tabRajadas.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbMonitoramentoTijolo.ResumeLayout(false);
            this.gbMonitoramentoTijolo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbMonitoramentoDigital.ResumeLayout(false);
            this.gbMonitoramentoDigital.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.gbMonitoramentoInvertida.ResumeLayout(false);
            this.gbMonitoramentoInvertida.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog apontaCaminhoPasta;
        private System.Windows.Forms.OpenFileDialog apontaCaminhoArquivo;
        private System.Windows.Forms.Timer tmRajadaTijolo;
        private System.Windows.Forms.Timer tmRajadaDigital;
        private System.Windows.Forms.Timer tmRajadaInvertida;
        private System.Windows.Forms.NotifyIcon niBandeja;
        private System.Windows.Forms.Timer tmMonitoramentoTijolo;
        private System.Windows.Forms.Timer tmMonitoramentoDigital;
        private System.Windows.Forms.Timer tmMonitoramentoInvertida;
        private System.Windows.Forms.Timer tmRotinaExpurgo;
        private System.Windows.Forms.Timer tmRotinaRestauracaoMonitoramento;
        private System.Windows.Forms.Timer tmLeituraCSVDetalhadoRegistro;
        private System.Windows.Forms.TabPage tabDetalhadoProdutividade;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button btnSalvarConfiguracoesDpItau;
        private System.Windows.Forms.Button btnLerCSVDpItau;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TabPage tabDetalhadoRegistro;
        private System.Windows.Forms.GroupBox gbBMG;
        private System.Windows.Forms.ProgressBar pbLeituraDRBMG;
        private System.Windows.Forms.Button btnSalvarConfiguracoesBMG;
        private System.Windows.Forms.Button btnLerCSVBMG;
        private System.Windows.Forms.Button btnDestinoCSVBMG;
        private System.Windows.Forms.TextBox tbDestinoCSVBMG;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnOrigemCSVBMG;
        private System.Windows.Forms.TextBox tbOrigemCSVBMG;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox gbDockTech;
        private System.Windows.Forms.ProgressBar pbLeituraDRDockTech;
        private System.Windows.Forms.Button btnSalvarConfiguracoesDOCKTECH;
        private System.Windows.Forms.Button btnLerCSVDockTech;
        private System.Windows.Forms.Button btnDestinoCSVDockTech;
        private System.Windows.Forms.TextBox tbDestinoCSVDockTech;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnOrigemCSVDockTech;
        private System.Windows.Forms.TextBox tbOrigemCSVDockTech;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox gbItau;
        private System.Windows.Forms.ProgressBar pbLeituraDRItau;
        private System.Windows.Forms.Button btnSalvarConfiguracoesITAU;
        private System.Windows.Forms.Button btnLerCSVItau;
        private System.Windows.Forms.Button btnDestinoCSVITAU;
        private System.Windows.Forms.TextBox tbDestinoCSVItau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrigemCSVITAU;
        private System.Windows.Forms.TextBox tbOrigemCSVItau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ComboBox cbStatusLeituraDR;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbIntervaloLeituraDR;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbFrequenciaLeituraDR;
        private System.Windows.Forms.GroupBox gbBradesco;
        private System.Windows.Forms.ProgressBar pbLeituraDR;
        private System.Windows.Forms.Button btnSalvarConfiguracoesDR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDestinoCSV;
        private System.Windows.Forms.TextBox tbDestinoCSVBradesco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOrigemCSV;
        private System.Windows.Forms.TextBox tbOrigemCSVBradesco;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabRajadas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox gbMonitoramentoInvertida;
        private System.Windows.Forms.Button btAgendamentoInvertida;
        private System.Windows.Forms.TextBox tbDestinatariosInvertida;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbStatusMonitoramentoInvertida;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ProgressBar pbLeituraInvertida;
        private System.Windows.Forms.Button btLerArquivoInvertida;
        private System.Windows.Forms.Button btSalvarArquivoInvertida;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbCopiarArquivoProcessadoRajadaInvertida;
        private System.Windows.Forms.RadioButton rbMoverArquivoProcessadoRajadaInvertida;
        private System.Windows.Forms.Button btCaminhoRajadaProcessadaTrintaTrinta;
        private System.Windows.Forms.TextBox tbCaminhoRajadaProcessadaInvertida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btApontaCaminhoRajadaTrintaTrinta;
        private System.Windows.Forms.TextBox tbCaminhoRajadaInvertida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox cbStatusLeituraInvertida;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbFrequenciaRajadaInvertida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbIntervaloRajadaInvertida;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbMonitoramentoDigital;
        private System.Windows.Forms.Button btAgendamentoDigital;
        private System.Windows.Forms.TextBox tbDestinatariosDigital;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbStatusMonitoramentoDigital;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ProgressBar pbLeituraDigital;
        private System.Windows.Forms.Button btLerArquivoDigital;
        private System.Windows.Forms.Button btSalvarArquivoDigital;
        private System.Windows.Forms.Button btCaminhoRajadaProcessadaDigital;
        private System.Windows.Forms.TextBox tbCaminhoRajadaProcessadaDigital;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCaminhoRajadaDigital;
        private System.Windows.Forms.TextBox tbCaminhoRajadaDigital;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox cbStatusLeituraDigital;
        private System.Windows.Forms.Label lbStatusLeituraDigital;
        private System.Windows.Forms.ComboBox cbFrequenciaRajadaDigital;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbCopiarArquivoProcessadoRajadaDigital;
        private System.Windows.Forms.RadioButton rbMoverArquivoProcessadoRajadaDigital;
        private System.Windows.Forms.TextBox tbIntervaloRajadaDigital;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbMonitoramentoTijolo;
        private System.Windows.Forms.Button btAgendamentoTijolo;
        private System.Windows.Forms.TextBox tbDestinatariosTijolo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbStatusMonitoramentoTijolo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ProgressBar pbLeituraTijolo;
        private System.Windows.Forms.Button btLerArquivoTijolo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCopiarArquivoProcessadoRajadaTijolo;
        private System.Windows.Forms.RadioButton rbMoverArquivoProcessadoRajadaTijolo;
        private System.Windows.Forms.Button btCaminhoRajadaProcessadaTijolo;
        private System.Windows.Forms.TextBox tbCaminhoRajadaProcessadaTijolo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCaminhoRajadaTijolo;
        private System.Windows.Forms.TextBox tbCaminhoRajadaTijolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cbStatusLeituraTijolo;
        private System.Windows.Forms.Button btSalvarArquivoTijolo;
        private System.Windows.Forms.Label lbStatusLeituraTijolo;
        private System.Windows.Forms.ComboBox cbFrequenciaRajadaTijolo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbIntervaloRajadaTijolo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

