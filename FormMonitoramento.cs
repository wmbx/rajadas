using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rajadas
{
    

    public partial class FormMonitoramento : Form
    {
        private String caminhoArquivoDeConfiguracao = "Parametros.xml";
        private String tipoRajada;
        private String enderecoBD;
        private String portaBD;
        private String usuarioBD;
        private String senhaBD;
        private String nomeBD;

        public string ParametroTipoRajada
        { 
            set { this.tipoRajada = value; }
        }

        public string ParametroNomeRajada
        {
            set { lbTipoRajada.Text = value; }
        }

        public FormMonitoramento()
        {
            InitializeComponent();
        }

        private void FormMonitoramento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void FormMonitoramento_Load(object sender, EventArgs e)
        {
            carregarParametrosBD();
            carregarGridViewMonitoramentoAtual();
            carregarGridViewMonitoramentoNovo();
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

        protected void carregarGridViewMonitoramentoAtual()
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            dgvMonitoramentoAtual.DataSource = bancoDeDados.listaTodosMonitoramentos(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, this.tipoRajada);
        }

        protected void carregarGridViewMonitoramentoNovo()
        {
            for (int i = 0; i < dgvMonitoramentoAtual.Rows.Count; i++)
            {
                dgvMonitoramentoNovo.Rows.Add();
            }
            for (int i = 0; i < dgvMonitoramentoAtual.Rows.Count; i++)
            {
                dgvMonitoramentoNovo.Rows[i].Cells["horario"].Value = dgvMonitoramentoAtual.Rows[i].Cells["horarioMonitoramento"].Value;
                dgvMonitoramentoNovo.Rows[i].Cells["arquivos"].Value = dgvMonitoramentoAtual.Rows[i].Cells["qtdArquivos"].Value;
            }
        }

        private void gbMonitoramento_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Monitoramento> listaMonitoramento = new List<Monitoramento>();

            BancoDeDados bancoDeDados = new BancoDeDados();

            if (DialogResult.Yes == MessageBox.Show("Deseja prosseguir com as alterações ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                try
                {
                    for (int i = 0; i < dgvMonitoramentoNovo.Rows.Count - 1; i++)
                    {
                        if (dgvMonitoramentoNovo.Rows[i].Cells["horario"].Value == null || dgvMonitoramentoNovo.Rows[i].Cells["arquivos"].Value == null)
                        {
                            MessageBox.Show("Não são permitidos campos vazios na tabela de monitoramento !!!");
                            return;
                        }

                        Monitoramento monitoramento = new Monitoramento();

                        monitoramento.codigoRajada = this.tipoRajada;
                        monitoramento.horarioMonitoramento = dgvMonitoramentoNovo.Rows[i].Cells["horario"].Value.ToString();
                        monitoramento.qtdArquivos = dgvMonitoramentoNovo.Rows[i].Cells["arquivos"].Value.ToString();

                        listaMonitoramento.Add(monitoramento);
                    }

                    Boolean retorno = bancoDeDados.atualizaTabelaDeMonitoramento(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaMonitoramento, this.tipoRajada);

                    if (retorno.Equals(true))
                    {
                        MessageBox.Show("Alterações realizadas com sucesso !!!");
                        carregarGridViewMonitoramentoAtual();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar alterações, tente novamente !!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvMonitoramentoNovo_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void dgvMonitoramentoNovo_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {            
            dgvMonitoramentoNovo.Rows[e.RowIndex].ErrorText = "";

            String valorCelula = e.FormattedValue.ToString();

            int numeroDaColunaGridView = dgvMonitoramentoNovo.Rows[e.ColumnIndex].Index;

            Monitoramento monitoramento = new Monitoramento();

            if (numeroDaColunaGridView == 0)
            {
                if (valorCelula != null)
                {
                    monitoramento.horarioMonitoramento = valorCelula;
                }
            }
            if (numeroDaColunaGridView == 1)
            {
                if (valorCelula != null)
                {
                    monitoramento.qtdArquivos = valorCelula;
                }
            }

            var erros = Validacao.ValidarCamposGridViewMonitoramento(monitoramento);

            if (dgvMonitoramentoNovo.Rows[e.RowIndex].IsNewRow) { return; }
            foreach (var error in erros)
            {
                e.Cancel = true;
                dgvMonitoramentoNovo.Rows[e.RowIndex].ErrorText = error.ErrorMessage;
            }
        }

        private void dgvMonitoramentoNovo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {}

        private void dgvMonitoramentoNovo_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
