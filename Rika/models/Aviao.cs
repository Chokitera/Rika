using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Aviao : Entidade
    {
        public CompanhiaAerea comp = new CompanhiaAerea();
        public Voo voo = new Voo();
        public Aviao() { 
            
        }
        public int idAviao { get ; set; }
        public int Qtd_Acento { get; set; }
        public string Modelo { get; set; }
        public string a { get; set; }
        public int Cod_Voo { get; set; }

    }
}
