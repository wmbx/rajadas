using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rajadas
{
    class Validacao
    {
        public static IEnumerable<ValidationResult> ValidarCampos(object objeto)
        {
            var resultadoValidacao = new List<ValidationResult>();

            var contexto = new ValidationContext(objeto, null, null);
            
            Validator.TryValidateObject(objeto, contexto, resultadoValidacao, true);
            
            return resultadoValidacao;
        }

    }
}
