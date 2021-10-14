using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Models
{
    [Table("TB_DEPART")]
    public class Departamento
    {
        [Column("ID")]
        public int DepartamentoId { get; set; }

        [Required, MaxLength(20), Display(Name ="Nome")]
        public string NomeDepart { get; set; }

        // relacionamento 1:N
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
