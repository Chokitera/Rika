using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Titulo : Entidade
    {
        public decimal Valor { get; set; }
        public Valores Nome_Valores { get; set; }
        public TipoVenda Nome_TipoVenda { get; set; }
    }
}
