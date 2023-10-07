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
        public Situacao situacao = new Situacao();  
        public Voo voo = new Voo();
        public Classe classe = new Classe();
        public double Valor {  get; set; }
        public string Direto_Escala { get; set; }
        public string Caminho_Img { get; set; }
    }
}
