using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class TipoVenda : Entidade
    {
        [Required(ErrorMessage = "A Descrição é obrigatória, não pode ser vazia!")]
        [StringLength(100, ErrorMessage = "A Descrição pode conter no máximo 100 caracteres!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A Descrição é obrigatória, não pode ser vazia!")]
        [StringLength(100, ErrorMessage = "A Descrição pode conter no máximo 100 caracteres!")]
        public string Nome { get; set; }
    }
}
