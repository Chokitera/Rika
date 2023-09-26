using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Passagem : Entidade
    {
        public string Cod_Passagem { get; set; }
        public string Descricao { get; set; }
        public Situacao Nome_Situacao { get; set; }
        public Valores Nome_Valores { get; set; }
        public Voo Nome_Voo { get; set; }
    }
}
