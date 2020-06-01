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
        private string valorDaCelula;

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
            // ** Cria objeto de Banco de Dados ** //
            BancoDeDados bancoDeDados = new BancoDeDados();

            // ** Busca a lista de monitoramento atual e atribui ao gridview monitoramento atual **//
            dgvMonitoramentoAtual.DataSource = bancoDeDados.listaTodosMonitoramentos(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, this.tipoRajada);

            // ** Busca os dias de monitoramento no banco de dados ** //
            DiaMonitoramento diaMonitoramento = new DiaMonitoramento();
            diaMonitoramento = bancoDeDados.listarDiasDeMonitoramento(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, this.tipoRajada);

            // ** Limpa a lista de checkbox atual ** //
            for (int i = 0; i < clbMonitoramentoAtual.Items.Count; i++)
            {
                clbMonitoramentoAtual.SetItemChecked(i, false);
            }

            // ** Seleciona os dias de monitoramento na lista de checkbox de acordo o retorno do banco de dados ** //
            foreach (var dia in diaMonitoramento.diaMonitoramento)
            {
                for (int i = 0; i < clbMonitoramentoAtual.Items.Count; i++)
                {
                    if (clbMonitoramentoAtual.Items[i].ToString() == dia)
                    {
                        clbMonitoramentoAtual.SetItemChecked(i, true);
                    }
                }
            }
        }

        protected void carregarGridViewMonitoramentoNovo()
        {
            dgvMonitoramentoNovo.Rows.Clear();
            for (int i = 0; i < dgvMonitoramentoAtual.Rows.Count; i++)
            {
                dgvMonitoramentoNovo.Rows.Add();
            }
            for (int i = 0; i < dgvMonitoramentoAtual.Rows.Count; i++)
            {
                dgvMonitoramentoNovo.Rows[i].Cells["horario"].Value = dgvMonitoramentoAtual.Rows[i].Cells["horarioMonitoramento"].Value;
                dgvMonitoramentoNovo.Rows[i].Cells["arquivos"].Value = dgvMonitoramentoAtual.Rows[i].Cells["qtdArquivos"].Value;
            }

            // ** Busca os dias de monitoramento no banco de dados ** //
            BancoDeDados bancoDeDados = new BancoDeDados();
            DiaMonitoramento diaMonitoramento = new DiaMonitoramento();
            diaMonitoramento = bancoDeDados.listarDiasDeMonitoramento(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, this.tipoRajada);

            // ** Limpa a lista de checkbox atual ** //
            for (int i = 0; i < clbMonitoramentoNovo.Items.Count; i++)
            {
                clbMonitoramentoNovo.SetItemChecked(i, false);
            }

            // ** Selecione os dias de monitoramento na lista de checkbox de acordo o retorno do banco de dados ** //
            foreach (var dia in diaMonitoramento.diaMonitoramento)
            {
                for (int i = 0; i < clbMonitoramentoNovo.Items.Count; i++)
                {
                    if (clbMonitoramentoNovo.Items[i].ToString() == dia)
                    {
                        clbMonitoramentoNovo.SetItemChecked(i, true);
                    }
                }
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

                    // ** Recupera os dias da semana marcados na lista de checkbox ** //
                    DiaMonitoramento diasMonitoramento = new DiaMonitoramento();
                    diasMonitoramento.codigoRajada = this.tipoRajada;

                    foreach (var dia in clbMonitoramentoNovo.CheckedItems)
                    {
                        diasMonitoramento.diaMonitoramento.Add(dia.ToString());
                    }

                    Boolean retorno = bancoDeDados.atualizaTabelaDeMonitoramento(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, listaMonitoramento, diasMonitoramento, this.tipoRajada);

                    if (retorno.Equals(true))
                    {
                        MessageBox.Show("Alterações realizadas com sucesso !!!");
                        carregarGridViewMonitoramentoAtual();
                        carregarGridViewMonitoramentoNovo();
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

            this.valorDaCelula = e.FormattedValue.ToString();

            string coluna = "";

            int numeroDaColunaGridView = dgvMonitoramentoNovo.Rows[e.ColumnIndex].Index;

            Monitoramento monitoramento = new Monitoramento();

            if (numeroDaColunaGridView == 0)
            {
                coluna = "horario";
                if (valorDaCelula != null)
                {
                    monitoramento.horarioMonitoramento = valorDaCelula;
                }
            }
            if (numeroDaColunaGridView == 1)
            {
                coluna = "arquivos";
                if (valorDaCelula != null)
                {
                    monitoramento.qtdArquivos = valorDaCelula;
                }
            }

            var erros = Validacao.ValidarCampos(monitoramento);

            if (dgvMonitoramentoNovo.Rows[e.RowIndex].IsNewRow) { return; }
            foreach (var error in erros)
            {
                e.Cancel = true;
                dgvMonitoramentoNovo.Rows[e.RowIndex].ErrorText = error.ErrorMessage;
            }


            // ** Percorre o gridview monitoramento novo para validar se existem horários duplicados ** //
            if (coluna == "horario")
            {
                for (int i = 0; i < dgvMonitoramentoNovo.Rows.Count - 1; i++)
                {
                    if (e.RowIndex != i)
                    {
                        if (dgvMonitoramentoNovo.Rows[i].Cells["horario"].Value.ToString() == valorDaCelula)
                        {
                            e.Cancel = true;
                            dgvMonitoramentoNovo.Rows[e.RowIndex].ErrorText = "Não são permitidos horários repetidos na tabela de monitoramento.";
                        }
                    }
                }
            }

            // ** Percorre o gridview monitoramento novo para validar se existem células vazias ** //
            for (int i = 0; i < dgvMonitoramentoNovo.Rows.Count - 1; i++)
            {
                if (valorDaCelula == "")
                {
                    e.Cancel = true;
                    dgvMonitoramentoNovo.Rows[e.RowIndex].ErrorText = "Não são permitidas células vazias na tabela de monitoramento.";
                }
            }
        }

        private void dgvMonitoramentoNovo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        { }

        private void dgvMonitoramentoNovo_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMonitoramentoNovo_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            // ** Valida se a coluna Horário está vazia ao mudar de linha ** //
            int linha = e.RowIndex;
            int ultimaLinhaGridView = dgvMonitoramentoNovo.Rows.Count - 1;
            if (linha != ultimaLinhaGridView)
            {
                if (dgvMonitoramentoNovo.Rows[linha].Cells["horario"].Value == null)
                {
                    e.Cancel = true;
                    dgvMonitoramentoNovo.Rows[e.RowIndex].ErrorText = "Não são permitidas células vazias na tabela de monitoramento.";
                }
            }            
        }

        private void btnRestaurarMonitoramento_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja prosseguir com as alterações ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    BancoDeDados bancoDeDados = new BancoDeDados();
                    Boolean retorno = bancoDeDados.RestaurarTabelaDeMonitoramentoAtual(this.enderecoBD, this.portaBD, this.usuarioBD, this.senhaBD, this.nomeBD, this.tipoRajada);
                    if (retorno.Equals(true))
                    {
                        MessageBox.Show("Tabela de monitoramento restaurada com sucesso !!!");
                        carregarGridViewMonitoramentoAtual();
                        carregarGridViewMonitoramentoNovo();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao restaurar a tabela de monitoramento, tente novamente !!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
