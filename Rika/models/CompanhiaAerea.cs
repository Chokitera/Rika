    using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class CompanhiaAerea : Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Inscrição { get; set; }
    }
}
