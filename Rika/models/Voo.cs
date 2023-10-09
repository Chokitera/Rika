using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Voo : Entidade
    {
        [Required(ErrorMessage = "O campo Destino não pode ser vazio!")]
        [Range(0, int.MaxValue, ErrorMessage = "Entrada inválida, é permitido somente números no Destino!")]
        public int Destino { get; set; }

        [Required(ErrorMessage = "O campo Decolagem não pode ser vazio!")]
        [Range(0, int.MaxValue, ErrorMessage = "Entrada inválida, é permitido somente números na Decolagem!")]
        public int Decolagem { get; set; }

        [Required(ErrorMessage = "O campo Data de Saída não pode ser vazio!")]
        [DataType(DataType.Date)]
        public DateTime DataSaida { get; set; }

        [Required(ErrorMessage = "O campo Data de Chegada não pode ser vazio!")]
        [DataType(DataType.Date)]
        public DateTime DataChegada { get; set; }

        [Required(ErrorMessage = "O campo Duração não pode ser vazio!")]
        [DataType(DataType.Time)]
        public DateTime Duracao { get; set; }

        [Required(ErrorMessage = "O campo Horário de Saída não pode ser vazio!")]
        [DataType(DataType.Time)]
        public DateTime HorarioSaida { get; set; }

        [Required(ErrorMessage = "O campo Horário de Chegada não pode ser vazio!")]
        [DataType(DataType.Time)]
        public DateTime HorarioChegada { get; set; }

        public Aviao aviao = new Aviao();
        public Aeroporto aeroporto = new Aeroporto();
    }
}
