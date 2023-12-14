using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class CarrinhoCompra : Entidade
    {
        public DateTime Dt_Adicao { get; set; }
        public int Quantidade { get; set; }
        public Usuario usuario = new Usuario();
        public Passagem passagem = new Passagem();
    }
}
