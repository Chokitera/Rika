using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class CompanhiaAerea : Entidade
    {
        public int idCompAerea { get; set; }

        public string Nome { get; set; }

        public string Inscricao { get; set; }

        public string Descricao { get; set; }

    }
}
