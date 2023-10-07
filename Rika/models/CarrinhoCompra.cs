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
        public virtual Usuario Usuario { get; set; } //Verificar se funciona, se não usar o modelo de baixo
        public Passagem passagem = new Passagem();
    }
}
