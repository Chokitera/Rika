using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Endereco : Entidade
    {
        [Required(ErrorMessage = "O campo Cidade não pode ser vazio!")]
        [StringLength(100, ErrorMessage = "A Cidade pode conter no máximo 100 caracteres!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo Estado não pode ser vazio!")]
        [StringLength(100, ErrorMessage = "O Estado pode conter no máximo 100 caracteres!")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O campo CEP não pode ser vazio!")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo Logradouro não pode ser vazio!")]
        [StringLength(200, ErrorMessage = "O Logradouro pode conter no máximo 200 caracteres!")]
        public string Logradouro { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Entrada inválida, é permitido somente números no Número da Casa!")]
        public int? NumeroCasa { get; set; }

        [StringLength(100, ErrorMessage = "O Complemento pode conter no máximo 100 caracteres!")]
        public string Complemento { get; set; }

        public Pais pais = new Pais();
    }
}
