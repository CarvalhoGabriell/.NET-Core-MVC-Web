using FIAP.aula03.Web.Entity.Models;
using FIAP.aula03.Web.Entity.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private FabricaContext _context;

        public DepartamentoRepository(FabricaContext context)
        {
            _context = context;
        }
        public void Cadastrar(Departamento depart)
        {
            _context.Departs.Add(depart);
        }

        public void Commitar()
        {
            _context.SaveChanges();
        }

        public IList<Departamento> Listar()
        {
            return _context.Departs.ToList();
        }

        public void Remover(int id)
        {
            var depart = _context.Departs.Find(id);
            _context.Departs.Remove(depart);
        }
    }
}
