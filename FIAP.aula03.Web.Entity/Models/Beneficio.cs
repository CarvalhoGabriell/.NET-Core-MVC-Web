using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Models
{
    [Table("TB_BENEFICIO")]
    public class Beneficio
    {
        [Column("ID")]
        public int BeneficioId { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        public bool Disponivel { get; set; }

        // N:N
        public ICollection<FuncionarioBeneficio> FuncionarioBeneficios { get; set; }
    }
}
