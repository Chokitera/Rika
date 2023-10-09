using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Titulo : Entidade
    {
        [Required(ErrorMessage = "O campo Valor não pode ser vazio!")]
        [Range(0, double.MaxValue, ErrorMessage = "Entrada inválida, é permitido somente números no Valor!")]
        public double Valor { get; set; }

        public TipoVenda tipovenda = new TipoVenda();
        public Passagem passagem = new Passagem();
    }
}
