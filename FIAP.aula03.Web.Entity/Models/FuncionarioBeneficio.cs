using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Models
{
    [Table("TB_FUNCIONARIO_BENEFICIO")]
    public class FuncionarioBeneficio
    {
        // Model criada para mapear uma tabela associativa para relacionamentos N:N

        public Funcionario Funcionario { get; set; }

        public int FuncionarioId { get; set; }


        public Beneficio Beneficio { get; set; }

        public int BeneficioId { get; set; }
    }
}
