using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rajadas
{
    class Monitoramento
    {
        public string codigoRajada;

        [Display(Name = "Horário da Rajada", Description = "Horário Formatado.")]
        [RegularExpression("^([0-1][0-9]|[2][0-3]):[0-5][0-9]$", ErrorMessage = "O formato de horário deve ser HH:MM. \nExemplo: 12:00")]
        public string horarioMonitoramento { get; set; }

        [Display(Name = "Quantidade de Arquivos", Description = "Quantidade Arquivos de Rajada")]
        [Range (1, 999, ErrorMessage = "A quantidade de arquivos deve estar entre 1 e 999.")]
        public string qtdArquivos { get; set; }

        
    }
}
