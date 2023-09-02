using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

    }
}
