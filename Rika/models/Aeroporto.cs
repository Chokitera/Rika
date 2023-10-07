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
        public Pais pais = new Pais();
        public Passagem passagem = new Passagem();
        public string Nome { get; set; }
    }
}
