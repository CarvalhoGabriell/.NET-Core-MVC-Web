using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Models
{
    [Table("TB_FUNCIONARIO")]
    public class Funcionario

    {
        [HiddenInput] // se o atributo que sera a PK for nomeado com id ou ClasseId nao é necessario usar o [KEY]
        public int FuncionarioId { get; set; }

        // relacionamento 1:1
        public Endereco Endereco { get; set; }

        public int? EnderecoId { get; set; }


        // relacionamento N:1
        public Departamento Departamento { get; set; }

        public int? DepartamentoId { get; set; }

        // relacionamento N:N
        public ICollection<FuncionarioBeneficio> FuncionarioBeneficios { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        // ? permite que o atributo seja null e nao seja mais obrigatorio
        public bool? Ativo { get; set; }

        [Column("DT_CONTRATACAO")] [DataType(DataType.Date)]
        public DateTime? DataContratacao { get; set; }

        [Required]
        public decimal Salario { get; set; }

        public Genero Genero { get; set; }

    }

    public enum Genero
    {
        Masculino,Feminino, Neutro,Outros
    }
}
