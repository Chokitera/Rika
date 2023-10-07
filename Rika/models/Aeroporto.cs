using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Aeroporto : Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Endereco endereco = new Endereco();
    }
}
