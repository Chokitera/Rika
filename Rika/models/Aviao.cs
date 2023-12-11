using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Aviao : Entidade
    {
        [Range(0, int.MaxValue, ErrorMessage = "Entrada inválida, é permitido somente números na Quantidade de Acento!")]
        public int Qtd_Acento { get; set; }

        [Required(ErrorMessage = "O campo Nome não pode ser vazio!")]
        [StringLength(100, ErrorMessage = "O Nome pode conter no máximo 100 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Modelo não pode ser vazio!")]
        [StringLength(100, ErrorMessage = "O Modelo pode conter no máximo 100 caracteres!")]
        public string Modelo { get; set; }

        public CompanhiaAerea comp = new CompanhiaAerea();
    }
}
