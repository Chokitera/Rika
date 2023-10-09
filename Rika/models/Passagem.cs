using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Passagem : Entidade
    {
        public string Cod_Passagem { get; set; }

        [Required(ErrorMessage = "O campo Valor não pode ser vazio!")]
        [Range(0, double.MaxValue, ErrorMessage = "Entrada inválida, é permitido somente números no Valor!")]
        public double Valor {  get; set; }

        [Required(ErrorMessage = "O campo Direto ou Escala não pode ser vazio!")]
        [StringLength(100, ErrorMessage = "O Direto ou Escala pode conter no máximo 100 caracteres!")]
        public string Direto_Escala { get; set; }

        [Required(ErrorMessage = "O campo da Imagem não pode ser vazio!")]
        [StringLength(200, ErrorMessage = "O Caminho da Imagem pode conter no máximo 200 caracteres!")]
        public string Caminho_Img { get; set; }

        public Situacao situacao = new Situacao();
        public Voo voo = new Voo();
        public Classe classe = new Classe();
    }
}
