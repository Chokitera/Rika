using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.dto
{
    public class LoginUsuarioDTO
    {
        [Required(ErrorMessage = "O campo Nome não pode ser vazio!")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "O campo Senha não pode ser vazio!")]
        public string Senha { get; set; }
    }
}
