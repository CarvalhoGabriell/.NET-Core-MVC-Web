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
        // a cada model adicionado deve ser mapeado aqui na classe de Context
        public DbSet<Funcionario>Funcionarios{ get; set; }

        public DbSet<Beneficio> Beneficios { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Departamento> Departs { get; set; }

        public DbSet<FuncionarioBeneficio> FuncionarioBeneficios { get; set; }

        public FabricaContext(DbContextOptions op) : base(op) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configurar a chave da tabela associativa com o funcionario
            modelBuilder.Entity<FuncionarioBeneficio>().HasKey(f => new { f.BeneficioId, f.FuncionarioId});

            // configurar a relação da tabela associativa com a tabela Funcionario
            modelBuilder.Entity<FuncionarioBeneficio>()
                .HasOne(f => f.Funcionario)
                .WithMany(f => f.FuncionarioBeneficios)
                .HasForeignKey(f => f.FuncionarioId);

            // configurar a relação da tabela associativa com a tabela Beneficio
            modelBuilder.Entity<FuncionarioBeneficio>()
                .HasOne(b => b.Beneficio)
                .WithMany(b => b.FuncionarioBeneficios)
                .HasForeignKey(b => b.BeneficioId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
