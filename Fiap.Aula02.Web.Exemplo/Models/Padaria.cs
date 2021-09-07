using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exemplo.Models
{
    public class Padaria
    {
        public int Codigo { get; set; }

        public bool Disponivel { get; set; }

        public string Nome { get; set; }

        [DataType(DataType.Date), Display(Name ="Data Abertura")]
        public DateTime DtAbertura { get; set; }

        public decimal Faturamento { get; set; }
    }
}
