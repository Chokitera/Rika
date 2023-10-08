using Rika.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.dto
{
    public class ExcluirCompAereaDTO
    {
        [Required(ErrorMessage = "O campo Código não pode ser vazio!")]
        [Range(0, int.MaxValue, ErrorMessage = "Entrada inválida, é permitido somente números no Código!")]
        public int? Id { get; set; }
    }
}
