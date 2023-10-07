using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Titulo : Entidade
    {
        public double Valor { get; set; }
        public TipoVenda tipovenda = new TipoVenda();
    }
}
