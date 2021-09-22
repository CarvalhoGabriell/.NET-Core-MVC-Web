using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.CP_1.SofiaBag.Models
{
    public class Objetos
    {
        [HiddenInput]
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Display(Name ="Categoria")]
        public Categoria Tipo { get; set; }

        [DataType(DataType.Date), Display(Name ="Data de Cadastro")]
        public DateTime DtCadastro { get; set; }

        [Display(Name ="Cores")]
        public string Cor { get; set; }
    }

    public enum Categoria {
        Pessoal, Trabalho, Escola, Faculdade,Essenciais, Lazer, Alimento
    }
}
