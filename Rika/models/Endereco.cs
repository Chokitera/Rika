using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Endereco : Entidade
    {
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int CEP { get; set; }
        public string Logradouro { get; set; }
        public int? NumeroCasa { get; set; }
        public string Complemento { get; set; }
        public Pais pais = new Pais();
    }
}
