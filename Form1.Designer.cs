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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCaminhoRajadaTijolo = new System.Windows.Forms.TextBox();
            this.tbCaminhoArquivoExcelTijolo = new System.Windows.Forms.TextBox();
            this.btCaminhoRajadaTijolo = new System.Windows.Forms.Button();
            this.btApontaArquivoExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCaminhoRajadaProcessadaTijolo = new System.Windows.Forms.TextBox();
            this.btCaminhoRajadaProcessadaTijolo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbLeituraTijolo = new System.Windows.Forms.ProgressBar();
            this.btLerArquivoTijolo = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbStatusLeituraTijolo = new System.Windows.Forms.ComboBox();
            this.lbStatusLeituraTijolo = new System.Windows.Forms.Label();
            this.cbFrequenciaRajadaTijolo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIntervaloRajadaTijolo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCopiarArquivoProcessadoRajadaTijolo = new System.Windows.Forms.RadioButton();
            this.rbMoverArquivoProcessadoRajadaTijolo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbLeituraDigital = new System.Windows.Forms.ProgressBar();
            this.btLerArquivoDigital = new System.Windows.Forms.Button();
            this.btSalvarArquivoDigital = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cbStatusLeituraDigital = new System.Windows.Forms.ComboBox();
            this.lbStatusLeituraDigital = new System.Windows.Forms.Label();
            this.cbFrequenciaRajadaDigital = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbIntervaloRajadaDigital = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbCopiarArquivoProcessadoRajadaDigital = new System.Windows.Forms.RadioButton();
            this.rbMoverArquivoProcessadoRajadaDigital = new System.Windows.Forms.RadioButton();
            this.btCaminhoRajadaProcessadaDigital = new System.Windows.Forms.Button();
            this.tbCaminhoRajadaProcessadaDigital = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCaminhoArquivoExcelRajadaDigital = new System.Windows.Forms.Button();
            this.btCaminhoRajadaDigital = new System.Windows.Forms.Button();
            this.tbCaminhoArquivoExcelRajadaDigital = new System.Windows.Forms.TextBox();
            this.tbCaminhoRajadaDigital = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbLeituraInvertida = new System.Windows.Forms.ProgressBar();
            this.btLerArquivoInvertida = new System.Windows.Forms.Button();
            this.btSalvarArquivoInvertida = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cbStatusLeituraInvertida = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbFrequenciaRajadaInvertida = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbIntervaloRajadaInvertida = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbCopiarArquivoProcessadoRajadaInvertida = new System.Windows.Forms.RadioButton();
            this.rbMoverArquivoProcessadoRajadaInvertida = new System.Windows.Forms.RadioButton();
            this.btCaminhoRajadaProcessadaTrintaTrinta = new System.Windows.Forms.Button();
            this.tbCaminhoRajadaProcessadaInvertida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btCaminhoArquivoExcelRajadaTrintaTrinta = new System.Windows.Forms.Button();
            this.btApontaCaminhoRajadaTrintaTrinta = new System.Windows.Forms.Button();
            this.tbCaminhoArquivoExcelRajadaInvertida = new System.Windows.Forms.TextBox();
            this.tbCaminhoRajadaInvertida = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tmRajadaTijolo = new System.Windows.Forms.Timer(this.components);
            this.tmRajadaDigital = new System.Windows.Forms.Timer(this.components);
            this.tmRajadaInvertida = new System.Windows.Forms.Timer(this.components);
            this.niBandeja = new System.Windows.Forms.NotifyIcon(this.components);
            this.btSalvarArquivoTijolo = new System.Windows.Forms.Button();
            this.tmMonitoramentoArquivosRajadaTijolo = new System.Windows.Forms.Timer(this.components);
            this.tmMonitoramentoArquivosRajadaDigital = new System.Windows.Forms.Timer(this.components);
            this.tmMonitoramentoArquivosRajadaInvertida = new System.Windows.Forms.Timer(this.components);
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho das rajadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caminho do aquivo excel";
            // 
            // tbCaminhoRajadaTijolo
            // 
            this.tbCaminhoRajadaTijolo.Location = new System.Drawing.Point(7, 33);
            this.tbCaminhoRajadaTijolo.Name = "tbCaminhoRajadaTijolo";
            this.tbCaminhoRajadaTijolo.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaTijolo.TabIndex = 3;
            // 
            // tbCaminhoArquivoExcelTijolo
            // 
            this.tbCaminhoArquivoExcelTijolo.Location = new System.Drawing.Point(7, 73);
            this.tbCaminhoArquivoExcelTijolo.Name = "tbCaminhoArquivoExcelTijolo";
            this.tbCaminhoArquivoExcelTijolo.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoArquivoExcelTijolo.TabIndex = 4;
            // 
            // btCaminhoRajadaTijolo
            // 
            this.btCaminhoRajadaTijolo.Location = new System.Drawing.Point(336, 32);
            this.btCaminhoRajadaTijolo.Name = "btCaminhoRajadaTijolo";
            this.btCaminhoRajadaTijolo.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaTijolo.TabIndex = 5;
            this.btCaminhoRajadaTijolo.Text = "...";
            this.btCaminhoRajadaTijolo.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaTijolo.Click += new System.EventHandler(this.botaoApontaCaminhoRajada_Click);
            // 
            // btApontaArquivoExcel
            // 
            this.btApontaArquivoExcel.Location = new System.Drawing.Point(336, 72);
            this.btApontaArquivoExcel.Name = "btApontaArquivoExcel";
            this.btApontaArquivoExcel.Size = new System.Drawing.Size(26, 22);
            this.btApontaArquivoExcel.TabIndex = 6;
            this.btApontaArquivoExcel.Text = "...";
            this.btApontaArquivoExcel.UseVisualStyleBackColor = true;
            this.btApontaArquivoExcel.Click += new System.EventHandler(this.botaoApontaArquivoExcel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Caminho das rajadas processadas";
            // 
            // tbCaminhoRajadaProcessadaTijolo
            // 
            this.tbCaminhoRajadaProcessadaTijolo.Location = new System.Drawing.Point(8, 110);
            this.tbCaminhoRajadaProcessadaTijolo.Name = "tbCaminhoRajadaProcessadaTijolo";
            this.tbCaminhoRajadaProcessadaTijolo.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaProcessadaTijolo.TabIndex = 8;
            // 
            // btCaminhoRajadaProcessadaTijolo
            // 
            this.btCaminhoRajadaProcessadaTijolo.Location = new System.Drawing.Point(337, 109);
            this.btCaminhoRajadaProcessadaTijolo.Name = "btCaminhoRajadaProcessadaTijolo";
            this.btCaminhoRajadaProcessadaTijolo.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaProcessadaTijolo.TabIndex = 9;
            this.btCaminhoRajadaProcessadaTijolo.Text = "...";
            this.btCaminhoRajadaProcessadaTijolo.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaProcessadaTijolo.Click += new System.EventHandler(this.btCaminhoRajadaProcessada_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox11);
            this.groupBox1.Controls.Add(this.pbLeituraTijolo);
            this.groupBox1.Controls.Add(this.btLerArquivoTijolo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btCaminhoRajadaProcessadaTijolo);
            this.groupBox1.Controls.Add(this.tbCaminhoRajadaProcessadaTijolo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btApontaArquivoExcel);
            this.groupBox1.Controls.Add(this.btCaminhoRajadaTijolo);
            this.groupBox1.Controls.Add(this.tbCaminhoArquivoExcelTijolo);
            this.groupBox1.Controls.Add(this.tbCaminhoRajadaTijolo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Location = new System.Drawing.Point(7, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 140);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rajada Tijolo";
            // 
            // pbLeituraTijolo
            // 
            this.pbLeituraTijolo.Location = new System.Drawing.Point(525, 80);
            this.pbLeituraTijolo.Name = "pbLeituraTijolo";
            this.pbLeituraTijolo.Size = new System.Drawing.Size(159, 21);
            this.pbLeituraTijolo.TabIndex = 15;
            this.pbLeituraTijolo.Visible = false;
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
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbStatusLeituraTijolo);
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
            // lbStatusLeituraTijolo
            // 
            this.lbStatusLeituraTijolo.AutoSize = true;
            this.lbStatusLeituraTijolo.Location = new System.Drawing.Point(6, 24);
            this.lbStatusLeituraTijolo.Name = "lbStatusLeituraTijolo";
            this.lbStatusLeituraTijolo.Size = new System.Drawing.Size(94, 13);
            this.lbStatusLeituraTijolo.TabIndex = 7;
            this.lbStatusLeituraTijolo.Text = "Leitura automática";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Frequência";
            // 
            // tbIntervaloRajadaTijolo
            // 
            this.tbIntervaloRajadaTijolo.Location = new System.Drawing.Point(8, 87);
            this.tbIntervaloRajadaTijolo.Name = "tbIntervaloRajadaTijolo";
            this.tbIntervaloRajadaTijolo.Size = new System.Drawing.Size(31, 20);
            this.tbIntervaloRajadaTijolo.TabIndex = 4;
            this.tbIntervaloRajadaTijolo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIntervaloRajadaTijolo_KeyPress);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox12);
            this.groupBox3.Controls.Add(this.pbLeituraDigital);
            this.groupBox3.Controls.Add(this.btLerArquivoDigital);
            this.groupBox3.Controls.Add(this.btSalvarArquivoDigital);
            this.groupBox3.Controls.Add(this.btCaminhoRajadaProcessadaDigital);
            this.groupBox3.Controls.Add(this.tbCaminhoRajadaProcessadaDigital);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btCaminhoArquivoExcelRajadaDigital);
            this.groupBox3.Controls.Add(this.btCaminhoRajadaDigital);
            this.groupBox3.Controls.Add(this.tbCaminhoArquivoExcelRajadaDigital);
            this.groupBox3.Controls.Add(this.tbCaminhoRajadaDigital);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.Location = new System.Drawing.Point(7, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(964, 140);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rajada Digital";
            // 
            // pbLeituraDigital
            // 
            this.pbLeituraDigital.Location = new System.Drawing.Point(525, 80);
            this.pbLeituraDigital.Name = "pbLeituraDigital";
            this.pbLeituraDigital.Size = new System.Drawing.Size(159, 21);
            this.pbLeituraDigital.TabIndex = 20;
            this.pbLeituraDigital.Visible = false;
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
            // lbStatusLeituraDigital
            // 
            this.lbStatusLeituraDigital.AutoSize = true;
            this.lbStatusLeituraDigital.Location = new System.Drawing.Point(6, 24);
            this.lbStatusLeituraDigital.Name = "lbStatusLeituraDigital";
            this.lbStatusLeituraDigital.Size = new System.Drawing.Size(94, 13);
            this.lbStatusLeituraDigital.TabIndex = 9;
            this.lbStatusLeituraDigital.Text = "Leitura automática";
            // 
            // cbFrequenciaRajadaDigital
            // 
            this.cbFrequenciaRajadaDigital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrequenciaRajadaDigital.FormattingEnabled = true;
            this.cbFrequenciaRajadaDigital.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.cbFrequenciaRajadaDigital.Location = new System.Drawing.Point(61, 86);
            this.cbFrequenciaRajadaDigital.Name = "cbFrequenciaRajadaDigital";
            this.cbFrequenciaRajadaDigital.Size = new System.Drawing.Size(73, 21);
            this.cbFrequenciaRajadaDigital.TabIndex = 6;
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
            // tbIntervaloRajadaDigital
            // 
            this.tbIntervaloRajadaDigital.Location = new System.Drawing.Point(8, 87);
            this.tbIntervaloRajadaDigital.Name = "tbIntervaloRajadaDigital";
            this.tbIntervaloRajadaDigital.Size = new System.Drawing.Size(31, 20);
            this.tbIntervaloRajadaDigital.TabIndex = 4;
            this.tbIntervaloRajadaDigital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIntervaloRajadaDigital_KeyPress);
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
            // btCaminhoRajadaProcessadaDigital
            // 
            this.btCaminhoRajadaProcessadaDigital.Location = new System.Drawing.Point(336, 109);
            this.btCaminhoRajadaProcessadaDigital.Name = "btCaminhoRajadaProcessadaDigital";
            this.btCaminhoRajadaProcessadaDigital.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaProcessadaDigital.TabIndex = 9;
            this.btCaminhoRajadaProcessadaDigital.Text = "...";
            this.btCaminhoRajadaProcessadaDigital.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaProcessadaDigital.Click += new System.EventHandler(this.btCaminhoRajadaProcessadaDigital_Click);
            // 
            // tbCaminhoRajadaProcessadaDigital
            // 
            this.tbCaminhoRajadaProcessadaDigital.Location = new System.Drawing.Point(7, 110);
            this.tbCaminhoRajadaProcessadaDigital.Name = "tbCaminhoRajadaProcessadaDigital";
            this.tbCaminhoRajadaProcessadaDigital.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaProcessadaDigital.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Caminho das rajadas processadas";
            // 
            // btCaminhoArquivoExcelRajadaDigital
            // 
            this.btCaminhoArquivoExcelRajadaDigital.Location = new System.Drawing.Point(336, 70);
            this.btCaminhoArquivoExcelRajadaDigital.Name = "btCaminhoArquivoExcelRajadaDigital";
            this.btCaminhoArquivoExcelRajadaDigital.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoArquivoExcelRajadaDigital.TabIndex = 6;
            this.btCaminhoArquivoExcelRajadaDigital.Text = "...";
            this.btCaminhoArquivoExcelRajadaDigital.UseVisualStyleBackColor = true;
            this.btCaminhoArquivoExcelRajadaDigital.Click += new System.EventHandler(this.btCaminhoArquivoExcelRajadaDigital_Click);
            // 
            // btCaminhoRajadaDigital
            // 
            this.btCaminhoRajadaDigital.Location = new System.Drawing.Point(336, 32);
            this.btCaminhoRajadaDigital.Name = "btCaminhoRajadaDigital";
            this.btCaminhoRajadaDigital.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaDigital.TabIndex = 5;
            this.btCaminhoRajadaDigital.Text = "...";
            this.btCaminhoRajadaDigital.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaDigital.Click += new System.EventHandler(this.btCaminhoRajadaDigital_Click);
            // 
            // tbCaminhoArquivoExcelRajadaDigital
            // 
            this.tbCaminhoArquivoExcelRajadaDigital.Location = new System.Drawing.Point(7, 71);
            this.tbCaminhoArquivoExcelRajadaDigital.Name = "tbCaminhoArquivoExcelRajadaDigital";
            this.tbCaminhoArquivoExcelRajadaDigital.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoArquivoExcelRajadaDigital.TabIndex = 4;
            // 
            // tbCaminhoRajadaDigital
            // 
            this.tbCaminhoRajadaDigital.Location = new System.Drawing.Point(7, 33);
            this.tbCaminhoRajadaDigital.Name = "tbCaminhoRajadaDigital";
            this.tbCaminhoRajadaDigital.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaDigital.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Caminho do aquivo excel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Caminho das rajadas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox13);
            this.groupBox4.Controls.Add(this.pbLeituraInvertida);
            this.groupBox4.Controls.Add(this.btLerArquivoInvertida);
            this.groupBox4.Controls.Add(this.btSalvarArquivoInvertida);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.btCaminhoRajadaProcessadaTrintaTrinta);
            this.groupBox4.Controls.Add(this.tbCaminhoRajadaProcessadaInvertida);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btCaminhoArquivoExcelRajadaTrintaTrinta);
            this.groupBox4.Controls.Add(this.btApontaCaminhoRajadaTrintaTrinta);
            this.groupBox4.Controls.Add(this.tbCaminhoArquivoExcelRajadaInvertida);
            this.groupBox4.Controls.Add(this.tbCaminhoRajadaInvertida);
            this.groupBox4.Controls.Add(this.label9);
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
            // pbLeituraInvertida
            // 
            this.pbLeituraInvertida.Location = new System.Drawing.Point(524, 80);
            this.pbLeituraInvertida.Name = "pbLeituraInvertida";
            this.pbLeituraInvertida.Size = new System.Drawing.Size(159, 21);
            this.pbLeituraInvertida.TabIndex = 22;
            this.pbLeituraInvertida.Visible = false;
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Leitura automática";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Frequência";
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Intervalo";
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
            // btCaminhoRajadaProcessadaTrintaTrinta
            // 
            this.btCaminhoRajadaProcessadaTrintaTrinta.Location = new System.Drawing.Point(336, 109);
            this.btCaminhoRajadaProcessadaTrintaTrinta.Name = "btCaminhoRajadaProcessadaTrintaTrinta";
            this.btCaminhoRajadaProcessadaTrintaTrinta.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaProcessadaTrintaTrinta.TabIndex = 9;
            this.btCaminhoRajadaProcessadaTrintaTrinta.Text = "...";
            this.btCaminhoRajadaProcessadaTrintaTrinta.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaProcessadaTrintaTrinta.Click += new System.EventHandler(this.btCaminhoRajadaProcessadaTrintaTrinta_Click);
            // 
            // tbCaminhoRajadaProcessadaInvertida
            // 
            this.tbCaminhoRajadaProcessadaInvertida.Location = new System.Drawing.Point(7, 110);
            this.tbCaminhoRajadaProcessadaInvertida.Name = "tbCaminhoRajadaProcessadaInvertida";
            this.tbCaminhoRajadaProcessadaInvertida.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaProcessadaInvertida.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Caminho das rajadas processadas";
            // 
            // btCaminhoArquivoExcelRajadaTrintaTrinta
            // 
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.Location = new System.Drawing.Point(336, 71);
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.Name = "btCaminhoArquivoExcelRajadaTrintaTrinta";
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.TabIndex = 6;
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.Text = "...";
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.UseVisualStyleBackColor = true;
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.Click += new System.EventHandler(this.btCaminhoArquivoExcelRajadaTrintaTrinta_Click);
            // 
            // btApontaCaminhoRajadaTrintaTrinta
            // 
            this.btApontaCaminhoRajadaTrintaTrinta.Location = new System.Drawing.Point(336, 32);
            this.btApontaCaminhoRajadaTrintaTrinta.Name = "btApontaCaminhoRajadaTrintaTrinta";
            this.btApontaCaminhoRajadaTrintaTrinta.Size = new System.Drawing.Size(26, 22);
            this.btApontaCaminhoRajadaTrintaTrinta.TabIndex = 5;
            this.btApontaCaminhoRajadaTrintaTrinta.Text = "...";
            this.btApontaCaminhoRajadaTrintaTrinta.UseVisualStyleBackColor = true;
            this.btApontaCaminhoRajadaTrintaTrinta.Click += new System.EventHandler(this.btApontaCaminhoRajadaTrintaTrinta_Click);
            // 
            // tbCaminhoArquivoExcelRajadaInvertida
            // 
            this.tbCaminhoArquivoExcelRajadaInvertida.Location = new System.Drawing.Point(7, 72);
            this.tbCaminhoArquivoExcelRajadaInvertida.Name = "tbCaminhoArquivoExcelRajadaInvertida";
            this.tbCaminhoArquivoExcelRajadaInvertida.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoArquivoExcelRajadaInvertida.TabIndex = 4;
            // 
            // tbCaminhoRajadaInvertida
            // 
            this.tbCaminhoRajadaInvertida.Location = new System.Drawing.Point(7, 33);
            this.tbCaminhoRajadaInvertida.Name = "tbCaminhoRajadaInvertida";
            this.tbCaminhoRajadaInvertida.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaInvertida.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Caminho do aquivo excel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Caminho das rajadas";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Location = new System.Drawing.Point(3, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(979, 468);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Configuração das Rajadas";
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
            // btSalvarArquivoTijolo
            // 
            this.btSalvarArquivoTijolo.Location = new System.Drawing.Point(535, 129);
            this.btSalvarArquivoTijolo.Name = "btSalvarArquivoTijolo";
            this.btSalvarArquivoTijolo.Size = new System.Drawing.Size(159, 21);
            this.btSalvarArquivoTijolo.TabIndex = 16;
            this.btSalvarArquivoTijolo.Text = "Salvar Configurações";
            this.btSalvarArquivoTijolo.UseVisualStyleBackColor = true;
            this.btSalvarArquivoTijolo.Click += new System.EventHandler(this.btSalvarArquivoTijolo_Click);
            // 
            // tmMonitoramentoArquivosRajadaTijolo
            // 
            this.tmMonitoramentoArquivosRajadaTijolo.Enabled = true;
            this.tmMonitoramentoArquivosRajadaTijolo.Interval = 600000;
            this.tmMonitoramentoArquivosRajadaTijolo.Tick += new System.EventHandler(this.tmMonitoramentoArquivosRajadaTijolo_Tick);
            // 
            // tmMonitoramentoArquivosRajadaDigital
            // 
            this.tmMonitoramentoArquivosRajadaDigital.Enabled = true;
            this.tmMonitoramentoArquivosRajadaDigital.Interval = 600000;
            this.tmMonitoramentoArquivosRajadaDigital.Tick += new System.EventHandler(this.tmMonitoramentoArquivosRajadaDigital_Tick);
            // 
            // tmMonitoramentoArquivosRajadaInvertida
            // 
            this.tmMonitoramentoArquivosRajadaInvertida.Enabled = true;
            this.tmMonitoramentoArquivosRajadaInvertida.Interval = 600000;
            this.tmMonitoramentoArquivosRajadaInvertida.Tick += new System.EventHandler(this.tmMonitoramentoArquivosRajadaInvertida_Tick);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button1);
            this.groupBox11.Controls.Add(this.textBox2);
            this.groupBox11.Controls.Add(this.label20);
            this.groupBox11.Controls.Add(this.comboBox1);
            this.groupBox11.Controls.Add(this.label17);
            this.groupBox11.Controls.Add(this.comboBox2);
            this.groupBox11.Controls.Add(this.label18);
            this.groupBox11.Controls.Add(this.textBox1);
            this.groupBox11.Controls.Add(this.label19);
            this.groupBox11.Location = new System.Drawing.Point(701, 12);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(255, 120);
            this.groupBox11.TabIndex = 15;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Configuração do Monitoramento";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Segundo";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ativada",
            "Desativada"});
            this.comboBox1.Location = new System.Drawing.Point(9, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Leitura automática";
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
            this.comboBox2.Location = new System.Drawing.Point(160, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(86, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(157, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Frequência";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(110, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Intervalo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Destinatários";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 21);
            this.button1.TabIndex = 17;
            this.button1.Text = "Salvar Configurações";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button2);
            this.groupBox12.Controls.Add(this.textBox3);
            this.groupBox12.Controls.Add(this.label21);
            this.groupBox12.Controls.Add(this.comboBox3);
            this.groupBox12.Controls.Add(this.label22);
            this.groupBox12.Controls.Add(this.comboBox4);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Controls.Add(this.textBox4);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.Location = new System.Drawing.Point(701, 12);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(255, 120);
            this.groupBox12.TabIndex = 21;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Configuração do Monitoramento";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 21);
            this.button2.TabIndex = 17;
            this.button2.Text = "Salvar Configurações";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Destinatários";
            // 
            // comboBox3
            // 
            this.comboBox3.DisplayMember = "Segundo";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Ativada",
            "Desativada"});
            this.comboBox3.Location = new System.Drawing.Point(9, 29);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(91, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Leitura automática";
            // 
            // comboBox4
            // 
            this.comboBox4.DisplayMember = "Segundo";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.comboBox4.Location = new System.Drawing.Point(160, 29);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(86, 21);
            this.comboBox4.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(157, 14);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Frequência";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(31, 20);
            this.textBox4.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(110, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Intervalo";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.button3);
            this.groupBox13.Controls.Add(this.textBox5);
            this.groupBox13.Controls.Add(this.label25);
            this.groupBox13.Controls.Add(this.comboBox5);
            this.groupBox13.Controls.Add(this.label26);
            this.groupBox13.Controls.Add(this.comboBox6);
            this.groupBox13.Controls.Add(this.label27);
            this.groupBox13.Controls.Add(this.textBox6);
            this.groupBox13.Controls.Add(this.label28);
            this.groupBox13.Location = new System.Drawing.Point(701, 12);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(255, 120);
            this.groupBox13.TabIndex = 23;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Configuração do Monitoramento";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 21);
            this.button3.TabIndex = 17;
            this.button3.Text = "Salvar Configurações";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(237, 20);
            this.textBox5.TabIndex = 10;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 13);
            this.label25.TabIndex = 9;
            this.label25.Text = "Destinatários";
            // 
            // comboBox5
            // 
            this.comboBox5.DisplayMember = "Segundo";
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Ativada",
            "Desativada"});
            this.comboBox5.Location = new System.Drawing.Point(9, 29);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(91, 21);
            this.comboBox5.TabIndex = 8;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 14);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(94, 13);
            this.label26.TabIndex = 7;
            this.label26.Text = "Leitura automática";
            // 
            // comboBox6
            // 
            this.comboBox6.DisplayMember = "Segundo";
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.comboBox6.Location = new System.Drawing.Point(160, 29);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(86, 21);
            this.comboBox6.TabIndex = 6;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(157, 14);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 13);
            this.label27.TabIndex = 5;
            this.label27.Text = "Frequência";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(114, 30);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(31, 20);
            this.textBox6.TabIndex = 4;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(110, 14);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "Intervalo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 480);
            this.Controls.Add(this.btSalvarArquivoTijolo);
            this.Controls.Add(this.groupBox5);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2000, 525);
            this.MinimumSize = new System.Drawing.Size(452, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BotFlow Rajadas V.1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog apontaCaminhoPasta;
        private System.Windows.Forms.OpenFileDialog apontaCaminhoArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCaminhoRajadaTijolo;
        private System.Windows.Forms.TextBox tbCaminhoArquivoExcelTijolo;
        private System.Windows.Forms.Button btCaminhoRajadaTijolo;
        private System.Windows.Forms.Button btApontaArquivoExcel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCaminhoRajadaProcessadaTijolo;
        private System.Windows.Forms.Button btCaminhoRajadaProcessadaTijolo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btCaminhoRajadaProcessadaDigital;
        private System.Windows.Forms.TextBox tbCaminhoRajadaProcessadaDigital;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCaminhoArquivoExcelRajadaDigital;
        private System.Windows.Forms.Button btCaminhoRajadaDigital;
        private System.Windows.Forms.TextBox tbCaminhoArquivoExcelRajadaDigital;
        private System.Windows.Forms.TextBox tbCaminhoRajadaDigital;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btCaminhoRajadaProcessadaTrintaTrinta;
        private System.Windows.Forms.TextBox tbCaminhoRajadaProcessadaInvertida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btCaminhoArquivoExcelRajadaTrintaTrinta;
        private System.Windows.Forms.Button btApontaCaminhoRajadaTrintaTrinta;
        private System.Windows.Forms.TextBox tbCaminhoArquivoExcelRajadaInvertida;
        private System.Windows.Forms.TextBox tbCaminhoRajadaInvertida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbMoverArquivoProcessadoRajadaTijolo;
        private System.Windows.Forms.RadioButton rbCopiarArquivoProcessadoRajadaTijolo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbCopiarArquivoProcessadoRajadaDigital;
        private System.Windows.Forms.RadioButton rbMoverArquivoProcessadoRajadaDigital;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbCopiarArquivoProcessadoRajadaInvertida;
        private System.Windows.Forms.RadioButton rbMoverArquivoProcessadoRajadaInvertida;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cbFrequenciaRajadaTijolo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbIntervaloRajadaTijolo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox cbFrequenciaRajadaDigital;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbIntervaloRajadaDigital;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox cbFrequenciaRajadaInvertida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbIntervaloRajadaInvertida;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer tmRajadaTijolo;
        private System.Windows.Forms.Timer tmRajadaDigital;
        private System.Windows.Forms.Timer tmRajadaInvertida;
        private System.Windows.Forms.NotifyIcon niBandeja;
        private System.Windows.Forms.ComboBox cbStatusLeituraTijolo;
        private System.Windows.Forms.Label lbStatusLeituraTijolo;
        private System.Windows.Forms.Button btLerArquivoTijolo;
        private System.Windows.Forms.Button btSalvarArquivoTijolo;
        private System.Windows.Forms.Button btLerArquivoDigital;
        private System.Windows.Forms.Button btSalvarArquivoDigital;
        private System.Windows.Forms.ComboBox cbStatusLeituraDigital;
        private System.Windows.Forms.Label lbStatusLeituraDigital;
        private System.Windows.Forms.Button btLerArquivoInvertida;
        private System.Windows.Forms.Button btSalvarArquivoInvertida;
        private System.Windows.Forms.ComboBox cbStatusLeituraInvertida;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ProgressBar pbLeituraTijolo;
        private System.Windows.Forms.ProgressBar pbLeituraDigital;
        private System.Windows.Forms.ProgressBar pbLeituraInvertida;
        private System.Windows.Forms.Timer tmMonitoramentoArquivosRajadaTijolo;
        private System.Windows.Forms.Timer tmMonitoramentoArquivosRajadaDigital;
        private System.Windows.Forms.Timer tmMonitoramentoArquivosRajadaInvertida;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label28;
    }
}

