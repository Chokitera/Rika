using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Aeroporto : Entidade
    {
        [Required(ErrorMessage = "O campo Nome não pode ser vazio!")]
        [StringLength(100, ErrorMessage = "O Nome pode conter no máximo 100 caracteres!")]
        public string Nome { get; set; }

        [StringLength(100, ErrorMessage = "A Descrição pode conter no máximo 100 caracteres!")]
        public string Descricao { get; set; }

        public Endereco endereco = new Endereco();
    }
}
