using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Pais : Entidade
    {
        [Required(ErrorMessage = "O campo Nome não pode ser vazio!")]
        [StringLength(100, ErrorMessage = "O Nome pode conter no máximo 100 caracteres!")]
        public string Nome {  get; set; }

        [Required(ErrorMessage = "O campo Sigla não pode ser vazio!")]
        [StringLength(2, ErrorMessage = "A Sigla pode conter no máximo 2 caracteres!")]
        public string Sigla { get; set; }
    }
}
