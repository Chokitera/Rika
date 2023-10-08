using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models.Comum
{
    public class ValidacaoModel
    {
        public void Validacao(object model)
        {
            string errorMessage = "";
            List<ValidationResult> resultado = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool ehValido = Validator.TryValidateObject(model, context, resultado, true);
            if (ehValido == false)
            {
                foreach (var item in resultado) 
                {
                    errorMessage += " - " + item.ErrorMessage + "\n";
                }
                throw new Exception(errorMessage);
            }
        }
    }
}
