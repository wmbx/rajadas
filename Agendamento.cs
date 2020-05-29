using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rajadas
{
    class Agendamento
    {
        
        private int agendamentoExecucaoEmMilesimos;
        private string diaAtualFormatado;


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

        // ** Método para retornar o dia atual da semana formatado ** //
        public string retornarDiaDaSemana()
        {
            string diaAtual = new CultureInfo("pt-BR").DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);

            if (diaAtual.Equals("segunda-feira"))
            {
                this.diaAtualFormatado = "Segunda";
            }
            if (diaAtual.Equals("terça-feira"))
            {
                this.diaAtualFormatado = "Terça";
            }
            if (diaAtual.Equals("quarta-feira"))
            {
                this.diaAtualFormatado = "Quarta";
            }
            if (diaAtual.Equals("quinta-feira"))
            {
                this.diaAtualFormatado = "Quinta";
            }
            if (diaAtual.Equals("sexta-feira"))
            {
                this.diaAtualFormatado = "Sexta";
            }
            if (diaAtual.Equals("sábado"))
            {
                this.diaAtualFormatado = "Sábado";
            }
            if (diaAtual.Equals("domingo"))
            {
                this.diaAtualFormatado = "Domingo";
            }

            return this.diaAtualFormatado;
        }
    }
}
