using FIAP.aula03.Web.Entity.Models;
using FIAP.aula03.Web.Entity.Persistencia;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private FabricaContext _context;

        public FuncionarioRepository(FabricaContext context)
        {
            _context = context;
        }
        public void Atualizar(Funcionario func)
        {
            _context.Funcionarios.Update(func);
        }

        public IList<Funcionario> BuscarPor(Expression<Func<Funcionario, bool>> filtro)
        {
           return _context.Funcionarios
                 .Where(filtro)
                 .Include(f => f.Endereco)
                 .Include(f => f.Departamento)
                 .ToList();
        }

        public Funcionario BuscarPorId(int id)
        {
           return _context.Funcionarios
                .Include(f => f.Endereco)
                .Include(f => f.Departamento)
                .Where(f => f.FuncionarioId == id)
                .FirstOrDefault();
        }

        public void Cadastrar(Funcionario func)
        {
            _context.Funcionarios.Add(func);
        }

        public void Commitar()
        {
            _context.SaveChanges();
        }

        public IList<Funcionario> Listar()
        {
            return _context.Funcionarios.ToList();
        }

        public void Remover(int id)
        {
            var func = _context.Funcionarios.Find(id);
            _context.Funcionarios.Remove(func);
        }

    }
}
