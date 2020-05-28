namespace rajadas
{
    partial class FormMonitoramento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonitoramento));
            this.dgvMonitoramentoAtual = new System.Windows.Forms.DataGridView();
            this.horarioMonitoramento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdArquivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMonitoramento = new System.Windows.Forms.GroupBox();
            this.btAtualizaMonitoramento = new System.Windows.Forms.Button();
            this.lbTipoRajada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMonitoramentoNovo = new System.Windows.Forms.DataGridView();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arquivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoramentoAtual)).BeginInit();
            this.gbMonitoramento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoramentoNovo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonitoramentoAtual
            // 
            this.dgvMonitoramentoAtual.AllowUserToAddRows = false;
            this.dgvMonitoramentoAtual.AllowUserToDeleteRows = false;
            this.dgvMonitoramentoAtual.AllowUserToResizeColumns = false;
            this.dgvMonitoramentoAtual.AllowUserToResizeRows = false;
            this.dgvMonitoramentoAtual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonitoramentoAtual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horarioMonitoramento,
            this.qtdArquivos});
            this.dgvMonitoramentoAtual.Location = new System.Drawing.Point(9, 52);
            this.dgvMonitoramentoAtual.Name = "dgvMonitoramentoAtual";
            this.dgvMonitoramentoAtual.ReadOnly = true;
            this.dgvMonitoramentoAtual.Size = new System.Drawing.Size(182, 353);
            this.dgvMonitoramentoAtual.TabIndex = 0;
            // 
            // horarioMonitoramento
            // 
            this.horarioMonitoramento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horarioMonitoramento.DataPropertyName = "horarioMonitoramento";
            this.horarioMonitoramento.HeaderText = "Horário";
            this.horarioMonitoramento.Name = "horarioMonitoramento";
            this.horarioMonitoramento.ReadOnly = true;
            this.horarioMonitoramento.Width = 66;
            // 
            // qtdArquivos
            // 
            this.qtdArquivos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qtdArquivos.DataPropertyName = "qtdArquivos";
            this.qtdArquivos.HeaderText = "Arquivos";
            this.qtdArquivos.Name = "qtdArquivos";
            this.qtdArquivos.ReadOnly = true;
            this.qtdArquivos.Width = 73;
            // 
            // gbMonitoramento
            // 
            this.gbMonitoramento.BackColor = System.Drawing.Color.Transparent;
            this.gbMonitoramento.Controls.Add(this.btAtualizaMonitoramento);
            this.gbMonitoramento.Controls.Add(this.lbTipoRajada);
            this.gbMonitoramento.Controls.Add(this.label3);
            this.gbMonitoramento.Controls.Add(this.label2);
            this.gbMonitoramento.Controls.Add(this.label1);
            this.gbMonitoramento.Controls.Add(this.dgvMonitoramentoAtual);
            this.gbMonitoramento.Controls.Add(this.dgvMonitoramentoNovo);
            this.gbMonitoramento.Location = new System.Drawing.Point(3, 7);
            this.gbMonitoramento.Name = "gbMonitoramento";
            this.gbMonitoramento.Size = new System.Drawing.Size(407, 439);
            this.gbMonitoramento.TabIndex = 1;
            this.gbMonitoramento.TabStop = false;
            this.gbMonitoramento.Text = "Configuração";
            this.gbMonitoramento.Enter += new System.EventHandler(this.gbMonitoramento_Enter);
            // 
            // btAtualizaMonitoramento
            // 
            this.btAtualizaMonitoramento.Location = new System.Drawing.Point(133, 410);
            this.btAtualizaMonitoramento.Name = "btAtualizaMonitoramento";
            this.btAtualizaMonitoramento.Size = new System.Drawing.Size(136, 25);
            this.btAtualizaMonitoramento.TabIndex = 6;
            this.btAtualizaMonitoramento.Text = " Atualizar Monitoramento";
            this.btAtualizaMonitoramento.UseVisualStyleBackColor = true;
            this.btAtualizaMonitoramento.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTipoRajada
            // 
            this.lbTipoRajada.AutoSize = true;
            this.lbTipoRajada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoRajada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTipoRajada.Location = new System.Drawing.Point(322, 11);
            this.lbTipoRajada.Name = "lbTipoRajada";
            this.lbTipoRajada.Size = new System.Drawing.Size(0, 19);
            this.lbTipoRajada.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rajada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monitoramento (Novo)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monitoramento (Atual)";
            // 
            // dgvMonitoramentoNovo
            // 
            this.dgvMonitoramentoNovo.AllowUserToResizeColumns = false;
            this.dgvMonitoramentoNovo.AllowUserToResizeRows = false;
            this.dgvMonitoramentoNovo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonitoramentoNovo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horario,
            this.arquivos});
            this.dgvMonitoramentoNovo.Location = new System.Drawing.Point(214, 52);
            this.dgvMonitoramentoNovo.Name = "dgvMonitoramentoNovo";
            this.dgvMonitoramentoNovo.Size = new System.Drawing.Size(182, 353);
            this.dgvMonitoramentoNovo.TabIndex = 1;
            this.dgvMonitoramentoNovo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonitoramentoNovo_CellEndEdit);
            this.dgvMonitoramentoNovo.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonitoramentoNovo_CellValidated);
            this.dgvMonitoramentoNovo.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvMonitoramentoNovo_CellValidating);
            this.dgvMonitoramentoNovo.Validating += new System.ComponentModel.CancelEventHandler(this.dgvMonitoramentoNovo_Validating);
            // 
            // horario
            // 
            this.horario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horario.HeaderText = "Horário";
            this.horario.Name = "horario";
            this.horario.Width = 66;
            // 
            // arquivos
            // 
            this.arquivos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.arquivos.HeaderText = "Arquivos";
            this.arquivos.Name = "arquivos";
            this.arquivos.Width = 73;
            // 
            // FormMonitoramento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.gbMonitoramento);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(429, 489);
            this.MinimumSize = new System.Drawing.Size(429, 489);
            this.Name = "FormMonitoramento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoramento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMonitoramento_FormClosed);
            this.Load += new System.EventHandler(this.FormMonitoramento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoramentoAtual)).EndInit();
            this.gbMonitoramento.ResumeLayout(false);
            this.gbMonitoramento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoramentoNovo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonitoramentoAtual;
        private System.Windows.Forms.GroupBox gbMonitoramento;
        private System.Windows.Forms.DataGridView dgvMonitoramentoNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioMonitoramento;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdArquivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTipoRajada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAtualizaMonitoramento;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn arquivos;
    }
}