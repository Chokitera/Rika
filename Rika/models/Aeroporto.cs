using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Aeroporto : Entidade
    {
        public string Descricao { get; set; }
        public Passagem Nome_Passagem { get; set; }
    }
}
