using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Aviao : Entidade
    {
        public int Qtd_Acento { get; set; }
        public string Modelo { get; set; }
        public CompanhiaAerea Nome_Companhia { get; set; }

    }
}
