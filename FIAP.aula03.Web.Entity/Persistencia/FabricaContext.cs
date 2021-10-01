using FIAP.aula03.Web.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Persistencia
{
    public class FabricaContext : DbContext
    {
        public DbSet<Funcionario>Funcionarios{ get; set; }

        public FabricaContext(DbContextOptions op) : base(op) { }
    }
}
