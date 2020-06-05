using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
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

        // ** Método que retorna o horário atual no formato HH:MM ** //
        public string RetornarHorarioAtualFormatado()
        {
            string hora = "";
            string horarioFormatado = "";
            try
            {
                hora = DateTime.Now.Hour.ToString();

                if (Convert.ToInt32(hora) < 10)
                {
                    hora = "0" + hora;
                }

                string minuto = DateTime.Now.Minute.ToString();

                if (Convert.ToInt32(minuto) < 10)
                {
                    minuto = "0" + minuto;
                }

                horarioFormatado = hora + ":" + minuto;
            }
            catch (Exception)
            {
                throw;
            }
                        
            return horarioFormatado;
        }


        // ** Método para verificar se o primeiro horário informado é maior que o segundo horário informado ** //
        public bool CompararMaiorHorario(string primeiroHorario, string segundoHorario)
        {
            bool retorno = false;
            try
            {
                // ** Retorna a HORA do primeiro horário ** //
                string horaPrimeiroHorario = primeiroHorario.Substring(0, 2);

                // ** Retorna os MINUTOS do primeiro horário ** //
                string minutosPrimeiroHorario = primeiroHorario.Substring(3, 2);

                // ** Converte o primeiro horário em minutos ** //
                int primeiroHorarioEmMinutos = (Convert.ToInt32(horaPrimeiroHorario) * 60) + Convert.ToInt32(minutosPrimeiroHorario);

                // ** Retorna a HORA do segundo horário ** //
                string horaSegundoHorario = segundoHorario.Substring(0, 2);

                // ** Retorna os MINUTOS do segundo horário ** //
                string minutosSegundoHorario = segundoHorario.Substring(3, 2);

                // ** Converte o segundo horário em minutos ** //
                int segundoHorarioEmMinutos = (Convert.ToInt32(horaSegundoHorario) * 60) + Convert.ToInt32(minutosSegundoHorario);

                if (primeiroHorarioEmMinutos > segundoHorarioEmMinutos)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return retorno;
        }

        public string RetornarDataAtualFormatadaAAAAMMDD()
        {
            string dataFormatada;
            try
            {
                // ** Pega a data atual e formata para para AAAA-MM-DD
                String dia = DateTime.Now.Day.ToString();
                if (Convert.ToInt32(dia) < 10)
                {
                    dia = "0" + dia;
                }
                String mes = DateTime.Now.Month.ToString();
                if (Convert.ToInt32(mes) < 10)
                {
                    mes = "0" + mes;
                }
                String ano = DateTime.Now.Year.ToString();
                dataFormatada = ano + "-" + mes + "-" + dia;
            }
            catch (Exception)
            {
                throw;
            }
            return dataFormatada;
        }
    }
}
