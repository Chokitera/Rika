    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class CompanhiaAerea : Entidade
    {
        [Required(ErrorMessage = "O campo Nome não pode ser vazio!")]
        [StringLength(100, ErrorMessage = "O Nome pode conter no máximo 100 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Descrição não pode ser vazio!")]
        [StringLength(100, ErrorMessage = "A Descrição pode conter no máximo 100 caracteres!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Inscrição não pode ser vazio!")]
        [StringLength(100, ErrorMessage = "A Inscrição pode conter no máximo 100 caracteres!")]
        public string Inscricao { get; set; }
    }
}
