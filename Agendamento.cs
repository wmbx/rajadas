using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rajadas
{
    class Agendamento
    {
        
        private int agendamentoExecucaoEmMilesimos;

        // --------------------- ** Recebe o intevalo e frequencia, converte em segundos e retorna para o formulário ** ------------------//
        public int retornaAgendamentoExecucao(String intervalo, String frequencia)
        {
            try
            {
                int multiplicador = 0;

                if (frequencia == "Segundos")
                {
                    multiplicador = 1000;
                }
            
                if (frequencia == "Minutos")
                {
                    multiplicador = 60000;
                }
            
                if (frequencia == "Horas")
                {
                    multiplicador = 3600000;
                }

                this.agendamentoExecucaoEmMilesimos = Convert.ToInt32(intervalo) * multiplicador;

            }

            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }

            return this.agendamentoExecucaoEmMilesimos;
        }
        // --------------------- ** Recebe o intevalo e frequencia, converte em segundos e retorna para o formulário ** ------------------//
    }
}
