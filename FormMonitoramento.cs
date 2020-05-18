using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rajadas
{
    public partial class FormMonitoramento : Form
    {
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
            BancoDeDados bancoDeDados = new BancoDeDados();
            dgvMonitoramento.DataSource = bancoDeDados.listaMonitoramento("127.0.0.1", "3306", "root", "160310", "itau", "1");
        }

        
    }
}
