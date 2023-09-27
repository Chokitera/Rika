using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Voo : Entidade
    {
        public string Descricao { get; set; }
        public int Destino { get; set; }
        public int Decolagem { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataChegada { get; set; }
        public DateTime Duracao { get; set; }
        public DateTime HorarioSaida { get; set; }
        public DateTime HorarioChegada { get; set; }
        public Aviao Cod_Aviao { get; set; }
    }
}
