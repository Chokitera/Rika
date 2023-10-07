using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Pais : Entidade
    {
        public string Nome {  get; set; }
        public string Sigla { get; set; }
    }
}
