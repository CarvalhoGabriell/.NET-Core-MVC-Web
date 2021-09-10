using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Aula02.Web.Exemplo.Models
{
    public class Padaria
    {
        [HiddenInput] // define o campo para a view como um campo oculto
        public int Codigo { get; set; }

        [Display(Name = "Disponivel")]
        public bool Disponivel { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.Date), Display(Name = "Data Abertura")]
        public DateTime DtAbertura { get; set; }

        public decimal Faturamento { get; set; }

        public Tamanho Tamanhos { get; set; }

        public string Cidade { get; set; }
    }
    public enum Tamanho
    {
        Pequeno, Médio, Grande
    }

}
