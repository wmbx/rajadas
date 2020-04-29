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
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbFrequenciaRajadaTijolo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIntervaloRajadaTijolo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCopiarArquivoProcessadoRajadaTijolo = new System.Windows.Forms.RadioButton();
            this.rbMoverArquivoProcessadoRajadaTijolo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
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
            this.groupBox10 = new System.Windows.Forms.GroupBox();
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
            this.btSalvarConfiguracoes = new System.Windows.Forms.Button();
            this.tmRajadaTijolo = new System.Windows.Forms.Timer(this.components);
            this.tmRajadaDigital = new System.Windows.Forms.Timer(this.components);
            this.tmRajadaInvertida = new System.Windows.Forms.Timer(this.components);
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ler Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho das rajadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caminho do aquivo excel";
            // 
            // tbCaminhoRajadaTijolo
            // 
            this.tbCaminhoRajadaTijolo.Location = new System.Drawing.Point(16, 34);
            this.tbCaminhoRajadaTijolo.Name = "tbCaminhoRajadaTijolo";
            this.tbCaminhoRajadaTijolo.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaTijolo.TabIndex = 3;
            // 
            // tbCaminhoArquivoExcelTijolo
            // 
            this.tbCaminhoArquivoExcelTijolo.Location = new System.Drawing.Point(16, 74);
            this.tbCaminhoArquivoExcelTijolo.Name = "tbCaminhoArquivoExcelTijolo";
            this.tbCaminhoArquivoExcelTijolo.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoArquivoExcelTijolo.TabIndex = 4;
            // 
            // btCaminhoRajadaTijolo
            // 
            this.btCaminhoRajadaTijolo.Location = new System.Drawing.Point(345, 33);
            this.btCaminhoRajadaTijolo.Name = "btCaminhoRajadaTijolo";
            this.btCaminhoRajadaTijolo.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaTijolo.TabIndex = 5;
            this.btCaminhoRajadaTijolo.Text = "...";
            this.btCaminhoRajadaTijolo.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaTijolo.Click += new System.EventHandler(this.botaoApontaCaminhoRajada_Click);
            // 
            // btApontaArquivoExcel
            // 
            this.btApontaArquivoExcel.Location = new System.Drawing.Point(345, 73);
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
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Caminho das rajadas processadas";
            // 
            // tbCaminhoRajadaProcessadaTijolo
            // 
            this.tbCaminhoRajadaProcessadaTijolo.Location = new System.Drawing.Point(17, 111);
            this.tbCaminhoRajadaProcessadaTijolo.Name = "tbCaminhoRajadaProcessadaTijolo";
            this.tbCaminhoRajadaProcessadaTijolo.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaProcessadaTijolo.TabIndex = 8;
            // 
            // btCaminhoRajadaProcessadaTijolo
            // 
            this.btCaminhoRajadaProcessadaTijolo.Location = new System.Drawing.Point(346, 110);
            this.btCaminhoRajadaProcessadaTijolo.Name = "btCaminhoRajadaProcessadaTijolo";
            this.btCaminhoRajadaProcessadaTijolo.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaProcessadaTijolo.TabIndex = 9;
            this.btCaminhoRajadaProcessadaTijolo.Text = "...";
            this.btCaminhoRajadaProcessadaTijolo.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaProcessadaTijolo.Click += new System.EventHandler(this.btCaminhoRajadaProcessada_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 145);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rajada Tijolo";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbFrequenciaRajadaTijolo);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.tbIntervaloRajadaTijolo);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Location = new System.Drawing.Point(383, 71);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(179, 64);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Agendamento";
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
            this.cbFrequenciaRajadaTijolo.Location = new System.Drawing.Point(61, 31);
            this.cbFrequenciaRajadaTijolo.Name = "cbFrequenciaRajadaTijolo";
            this.cbFrequenciaRajadaTijolo.Size = new System.Drawing.Size(106, 21);
            this.cbFrequenciaRajadaTijolo.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Frequência";
            // 
            // tbIntervaloRajadaTijolo
            // 
            this.tbIntervaloRajadaTijolo.Location = new System.Drawing.Point(8, 32);
            this.tbIntervaloRajadaTijolo.Name = "tbIntervaloRajadaTijolo";
            this.tbIntervaloRajadaTijolo.Size = new System.Drawing.Size(31, 20);
            this.tbIntervaloRajadaTijolo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Intervalo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCopiarArquivoProcessadoRajadaTijolo);
            this.groupBox2.Controls.Add(this.rbMoverArquivoProcessadoRajadaTijolo);
            this.groupBox2.Location = new System.Drawing.Point(383, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 62);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuração Arquivo TXT";
            // 
            // rbCopiarArquivoProcessadoRajadaTijolo
            // 
            this.rbCopiarArquivoProcessadoRajadaTijolo.AutoSize = true;
            this.rbCopiarArquivoProcessadoRajadaTijolo.Location = new System.Drawing.Point(6, 16);
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
            this.rbMoverArquivoProcessadoRajadaTijolo.Location = new System.Drawing.Point(6, 37);
            this.rbMoverArquivoProcessadoRajadaTijolo.Name = "rbMoverArquivoProcessadoRajadaTijolo";
            this.rbMoverArquivoProcessadoRajadaTijolo.Size = new System.Drawing.Size(153, 17);
            this.rbMoverArquivoProcessadoRajadaTijolo.TabIndex = 12;
            this.rbMoverArquivoProcessadoRajadaTijolo.Text = "Mover Arquivo Processado";
            this.rbMoverArquivoProcessadoRajadaTijolo.UseVisualStyleBackColor = true;
            this.rbMoverArquivoProcessadoRajadaTijolo.CheckedChanged += new System.EventHandler(this.rbMoverArquivoProcessadoRajadaTijolo_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.btCaminhoRajadaProcessadaDigital);
            this.groupBox3.Controls.Add(this.tbCaminhoRajadaProcessadaDigital);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btCaminhoArquivoExcelRajadaDigital);
            this.groupBox3.Controls.Add(this.btCaminhoRajadaDigital);
            this.groupBox3.Controls.Add(this.tbCaminhoArquivoExcelRajadaDigital);
            this.groupBox3.Controls.Add(this.tbCaminhoRajadaDigital);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(7, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 149);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rajada Digital";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cbFrequenciaRajadaDigital);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.tbIntervaloRajadaDigital);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Location = new System.Drawing.Point(383, 75);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(179, 64);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Agendamento";
            // 
            // cbFrequenciaRajadaDigital
            // 
            this.cbFrequenciaRajadaDigital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrequenciaRajadaDigital.FormattingEnabled = true;
            this.cbFrequenciaRajadaDigital.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.cbFrequenciaRajadaDigital.Location = new System.Drawing.Point(61, 31);
            this.cbFrequenciaRajadaDigital.Name = "cbFrequenciaRajadaDigital";
            this.cbFrequenciaRajadaDigital.Size = new System.Drawing.Size(106, 21);
            this.cbFrequenciaRajadaDigital.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Frequência";
            // 
            // tbIntervaloRajadaDigital
            // 
            this.tbIntervaloRajadaDigital.Location = new System.Drawing.Point(8, 32);
            this.tbIntervaloRajadaDigital.Name = "tbIntervaloRajadaDigital";
            this.tbIntervaloRajadaDigital.Size = new System.Drawing.Size(31, 20);
            this.tbIntervaloRajadaDigital.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Intervalo";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbCopiarArquivoProcessadoRajadaDigital);
            this.groupBox6.Controls.Add(this.rbMoverArquivoProcessadoRajadaDigital);
            this.groupBox6.Location = new System.Drawing.Point(383, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(179, 66);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Configuração Arquivo TXT";
            // 
            // rbCopiarArquivoProcessadoRajadaDigital
            // 
            this.rbCopiarArquivoProcessadoRajadaDigital.AutoSize = true;
            this.rbCopiarArquivoProcessadoRajadaDigital.Location = new System.Drawing.Point(6, 22);
            this.rbCopiarArquivoProcessadoRajadaDigital.Name = "rbCopiarArquivoProcessadoRajadaDigital";
            this.rbCopiarArquivoProcessadoRajadaDigital.Size = new System.Drawing.Size(153, 17);
            this.rbCopiarArquivoProcessadoRajadaDigital.TabIndex = 11;
            this.rbCopiarArquivoProcessadoRajadaDigital.Text = "Copiar Arquivo Processado";
            this.rbCopiarArquivoProcessadoRajadaDigital.UseVisualStyleBackColor = true;
            // 
            // rbMoverArquivoProcessadoRajadaDigital
            // 
            this.rbMoverArquivoProcessadoRajadaDigital.AutoSize = true;
            this.rbMoverArquivoProcessadoRajadaDigital.Location = new System.Drawing.Point(6, 43);
            this.rbMoverArquivoProcessadoRajadaDigital.Name = "rbMoverArquivoProcessadoRajadaDigital";
            this.rbMoverArquivoProcessadoRajadaDigital.Size = new System.Drawing.Size(153, 17);
            this.rbMoverArquivoProcessadoRajadaDigital.TabIndex = 12;
            this.rbMoverArquivoProcessadoRajadaDigital.Text = "Mover Arquivo Processado";
            this.rbMoverArquivoProcessadoRajadaDigital.UseVisualStyleBackColor = true;
            // 
            // btCaminhoRajadaProcessadaDigital
            // 
            this.btCaminhoRajadaProcessadaDigital.Location = new System.Drawing.Point(345, 110);
            this.btCaminhoRajadaProcessadaDigital.Name = "btCaminhoRajadaProcessadaDigital";
            this.btCaminhoRajadaProcessadaDigital.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaProcessadaDigital.TabIndex = 9;
            this.btCaminhoRajadaProcessadaDigital.Text = "...";
            this.btCaminhoRajadaProcessadaDigital.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaProcessadaDigital.Click += new System.EventHandler(this.btCaminhoRajadaProcessadaDigital_Click);
            // 
            // tbCaminhoRajadaProcessadaDigital
            // 
            this.tbCaminhoRajadaProcessadaDigital.Location = new System.Drawing.Point(16, 111);
            this.tbCaminhoRajadaProcessadaDigital.Name = "tbCaminhoRajadaProcessadaDigital";
            this.tbCaminhoRajadaProcessadaDigital.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaProcessadaDigital.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Caminho das rajadas processadas";
            // 
            // btCaminhoArquivoExcelRajadaDigital
            // 
            this.btCaminhoArquivoExcelRajadaDigital.Location = new System.Drawing.Point(345, 71);
            this.btCaminhoArquivoExcelRajadaDigital.Name = "btCaminhoArquivoExcelRajadaDigital";
            this.btCaminhoArquivoExcelRajadaDigital.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoArquivoExcelRajadaDigital.TabIndex = 6;
            this.btCaminhoArquivoExcelRajadaDigital.Text = "...";
            this.btCaminhoArquivoExcelRajadaDigital.UseVisualStyleBackColor = true;
            this.btCaminhoArquivoExcelRajadaDigital.Click += new System.EventHandler(this.btCaminhoArquivoExcelRajadaDigital_Click);
            // 
            // btCaminhoRajadaDigital
            // 
            this.btCaminhoRajadaDigital.Location = new System.Drawing.Point(345, 33);
            this.btCaminhoRajadaDigital.Name = "btCaminhoRajadaDigital";
            this.btCaminhoRajadaDigital.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaDigital.TabIndex = 5;
            this.btCaminhoRajadaDigital.Text = "...";
            this.btCaminhoRajadaDigital.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaDigital.Click += new System.EventHandler(this.btCaminhoRajadaDigital_Click);
            // 
            // tbCaminhoArquivoExcelRajadaDigital
            // 
            this.tbCaminhoArquivoExcelRajadaDigital.Location = new System.Drawing.Point(16, 72);
            this.tbCaminhoArquivoExcelRajadaDigital.Name = "tbCaminhoArquivoExcelRajadaDigital";
            this.tbCaminhoArquivoExcelRajadaDigital.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoArquivoExcelRajadaDigital.TabIndex = 4;
            // 
            // tbCaminhoRajadaDigital
            // 
            this.tbCaminhoRajadaDigital.Location = new System.Drawing.Point(16, 34);
            this.tbCaminhoRajadaDigital.Name = "tbCaminhoRajadaDigital";
            this.tbCaminhoRajadaDigital.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaDigital.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Caminho do aquivo excel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Caminho das rajadas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox10);
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
            this.groupBox4.Location = new System.Drawing.Point(7, 315);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(576, 150);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rajada Invertida";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cbFrequenciaRajadaInvertida);
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Controls.Add(this.tbIntervaloRajadaInvertida);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Location = new System.Drawing.Point(383, 76);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(179, 64);
            this.groupBox10.TabIndex = 16;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Agendamento";
            // 
            // cbFrequenciaRajadaInvertida
            // 
            this.cbFrequenciaRajadaInvertida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrequenciaRajadaInvertida.FormattingEnabled = true;
            this.cbFrequenciaRajadaInvertida.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.cbFrequenciaRajadaInvertida.Location = new System.Drawing.Point(61, 31);
            this.cbFrequenciaRajadaInvertida.Name = "cbFrequenciaRajadaInvertida";
            this.cbFrequenciaRajadaInvertida.Size = new System.Drawing.Size(106, 21);
            this.cbFrequenciaRajadaInvertida.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Frequência";
            // 
            // tbIntervaloRajadaInvertida
            // 
            this.tbIntervaloRajadaInvertida.Location = new System.Drawing.Point(8, 32);
            this.tbIntervaloRajadaInvertida.Name = "tbIntervaloRajadaInvertida";
            this.tbIntervaloRajadaInvertida.Size = new System.Drawing.Size(31, 20);
            this.tbIntervaloRajadaInvertida.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Intervalo";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbCopiarArquivoProcessadoRajadaInvertida);
            this.groupBox7.Controls.Add(this.rbMoverArquivoProcessadoRajadaInvertida);
            this.groupBox7.Location = new System.Drawing.Point(383, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(179, 66);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Configuração Arquivo TXT";
            // 
            // rbCopiarArquivoProcessadoRajadaInvertida
            // 
            this.rbCopiarArquivoProcessadoRajadaInvertida.AutoSize = true;
            this.rbCopiarArquivoProcessadoRajadaInvertida.Location = new System.Drawing.Point(6, 22);
            this.rbCopiarArquivoProcessadoRajadaInvertida.Name = "rbCopiarArquivoProcessadoRajadaInvertida";
            this.rbCopiarArquivoProcessadoRajadaInvertida.Size = new System.Drawing.Size(153, 17);
            this.rbCopiarArquivoProcessadoRajadaInvertida.TabIndex = 11;
            this.rbCopiarArquivoProcessadoRajadaInvertida.Text = "Copiar Arquivo Processado";
            this.rbCopiarArquivoProcessadoRajadaInvertida.UseVisualStyleBackColor = true;
            // 
            // rbMoverArquivoProcessadoRajadaInvertida
            // 
            this.rbMoverArquivoProcessadoRajadaInvertida.AutoSize = true;
            this.rbMoverArquivoProcessadoRajadaInvertida.Location = new System.Drawing.Point(6, 43);
            this.rbMoverArquivoProcessadoRajadaInvertida.Name = "rbMoverArquivoProcessadoRajadaInvertida";
            this.rbMoverArquivoProcessadoRajadaInvertida.Size = new System.Drawing.Size(153, 17);
            this.rbMoverArquivoProcessadoRajadaInvertida.TabIndex = 12;
            this.rbMoverArquivoProcessadoRajadaInvertida.Text = "Mover Arquivo Processado";
            this.rbMoverArquivoProcessadoRajadaInvertida.UseVisualStyleBackColor = true;
            // 
            // btCaminhoRajadaProcessadaTrintaTrinta
            // 
            this.btCaminhoRajadaProcessadaTrintaTrinta.Location = new System.Drawing.Point(345, 110);
            this.btCaminhoRajadaProcessadaTrintaTrinta.Name = "btCaminhoRajadaProcessadaTrintaTrinta";
            this.btCaminhoRajadaProcessadaTrintaTrinta.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoRajadaProcessadaTrintaTrinta.TabIndex = 9;
            this.btCaminhoRajadaProcessadaTrintaTrinta.Text = "...";
            this.btCaminhoRajadaProcessadaTrintaTrinta.UseVisualStyleBackColor = true;
            this.btCaminhoRajadaProcessadaTrintaTrinta.Click += new System.EventHandler(this.btCaminhoRajadaProcessadaTrintaTrinta_Click);
            // 
            // tbCaminhoRajadaProcessadaInvertida
            // 
            this.tbCaminhoRajadaProcessadaInvertida.Location = new System.Drawing.Point(16, 111);
            this.tbCaminhoRajadaProcessadaInvertida.Name = "tbCaminhoRajadaProcessadaInvertida";
            this.tbCaminhoRajadaProcessadaInvertida.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaProcessadaInvertida.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Caminho das rajadas processadas";
            // 
            // btCaminhoArquivoExcelRajadaTrintaTrinta
            // 
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.Location = new System.Drawing.Point(345, 72);
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.Name = "btCaminhoArquivoExcelRajadaTrintaTrinta";
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.Size = new System.Drawing.Size(26, 22);
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.TabIndex = 6;
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.Text = "...";
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.UseVisualStyleBackColor = true;
            this.btCaminhoArquivoExcelRajadaTrintaTrinta.Click += new System.EventHandler(this.btCaminhoArquivoExcelRajadaTrintaTrinta_Click);
            // 
            // btApontaCaminhoRajadaTrintaTrinta
            // 
            this.btApontaCaminhoRajadaTrintaTrinta.Location = new System.Drawing.Point(345, 33);
            this.btApontaCaminhoRajadaTrintaTrinta.Name = "btApontaCaminhoRajadaTrintaTrinta";
            this.btApontaCaminhoRajadaTrintaTrinta.Size = new System.Drawing.Size(26, 22);
            this.btApontaCaminhoRajadaTrintaTrinta.TabIndex = 5;
            this.btApontaCaminhoRajadaTrintaTrinta.Text = "...";
            this.btApontaCaminhoRajadaTrintaTrinta.UseVisualStyleBackColor = true;
            this.btApontaCaminhoRajadaTrintaTrinta.Click += new System.EventHandler(this.btApontaCaminhoRajadaTrintaTrinta_Click);
            // 
            // tbCaminhoArquivoExcelRajadaInvertida
            // 
            this.tbCaminhoArquivoExcelRajadaInvertida.Location = new System.Drawing.Point(16, 73);
            this.tbCaminhoArquivoExcelRajadaInvertida.Name = "tbCaminhoArquivoExcelRajadaInvertida";
            this.tbCaminhoArquivoExcelRajadaInvertida.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoArquivoExcelRajadaInvertida.TabIndex = 4;
            // 
            // tbCaminhoRajadaInvertida
            // 
            this.tbCaminhoRajadaInvertida.Location = new System.Drawing.Point(16, 34);
            this.tbCaminhoRajadaInvertida.Name = "tbCaminhoRajadaInvertida";
            this.tbCaminhoRajadaInvertida.Size = new System.Drawing.Size(329, 20);
            this.tbCaminhoRajadaInvertida.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Caminho do aquivo excel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 19);
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
            this.groupBox5.Size = new System.Drawing.Size(590, 474);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Configuração das Rajadas";
            // 
            // btSalvarConfiguracoes
            // 
            this.btSalvarConfiguracoes.Location = new System.Drawing.Point(112, 482);
            this.btSalvarConfiguracoes.Name = "btSalvarConfiguracoes";
            this.btSalvarConfiguracoes.Size = new System.Drawing.Size(124, 21);
            this.btSalvarConfiguracoes.TabIndex = 15;
            this.btSalvarConfiguracoes.Text = "Salvar Configurações";
            this.btSalvarConfiguracoes.UseVisualStyleBackColor = true;
            this.btSalvarConfiguracoes.Click += new System.EventHandler(this.btSalvarConfiguracoes_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 506);
            this.Controls.Add(this.btSalvarConfiguracoes);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(612, 545);
            this.MinimumSize = new System.Drawing.Size(612, 545);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BotFlow Rajadas v.1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button btSalvarConfiguracoes;
        private System.Windows.Forms.Timer tmRajadaTijolo;
        private System.Windows.Forms.Timer tmRajadaDigital;
        private System.Windows.Forms.Timer tmRajadaInvertida;
    }
}

