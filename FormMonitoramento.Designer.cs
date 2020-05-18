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
            this.dgvMonitoramento = new System.Windows.Forms.DataGridView();
            this.gbMonitoramento = new System.Windows.Forms.GroupBox();
            this.codigoRajada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioMonitoramento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdArquivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoramento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonitoramento
            // 
            this.dgvMonitoramento.AllowUserToResizeColumns = false;
            this.dgvMonitoramento.AllowUserToResizeRows = false;
            this.dgvMonitoramento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonitoramento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoRajada,
            this.horarioMonitoramento,
            this.qtdArquivos});
            this.dgvMonitoramento.Location = new System.Drawing.Point(29, 47);
            this.dgvMonitoramento.Name = "dgvMonitoramento";
            this.dgvMonitoramento.Size = new System.Drawing.Size(182, 353);
            this.dgvMonitoramento.TabIndex = 0;
            // 
            // gbMonitoramento
            // 
            this.gbMonitoramento.Location = new System.Drawing.Point(12, 12);
            this.gbMonitoramento.Name = "gbMonitoramento";
            this.gbMonitoramento.Size = new System.Drawing.Size(219, 426);
            this.gbMonitoramento.TabIndex = 1;
            this.gbMonitoramento.TabStop = false;
            this.gbMonitoramento.Text = "Configuração do Monitoramento";
            // 
            // codigoRajada
            // 
            this.codigoRajada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoRajada.HeaderText = "Código Rajada";
            this.codigoRajada.Name = "codigoRajada";
            this.codigoRajada.Visible = false;
            this.codigoRajada.Width = 102;
            // 
            // horarioMonitoramento
            // 
            this.horarioMonitoramento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horarioMonitoramento.HeaderText = "Horário";
            this.horarioMonitoramento.Name = "horarioMonitoramento";
            this.horarioMonitoramento.Width = 66;
            // 
            // qtdArquivos
            // 
            this.qtdArquivos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qtdArquivos.HeaderText = "Arquivos";
            this.qtdArquivos.Name = "qtdArquivos";
            this.qtdArquivos.Width = 73;
            // 
            // FormMonitoramento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 450);
            this.Controls.Add(this.dgvMonitoramento);
            this.Controls.Add(this.gbMonitoramento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMonitoramento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoramento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMonitoramento_FormClosed);
            this.Load += new System.EventHandler(this.FormMonitoramento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoramento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonitoramento;
        private System.Windows.Forms.GroupBox gbMonitoramento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoRajada;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioMonitoramento;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdArquivos;
    }
}