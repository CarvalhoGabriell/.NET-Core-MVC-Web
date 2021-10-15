using FIAP.aula03.Web.Entity.Models;
using FIAP.aula03.Web.Entity.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Repositories
{
    public class BeneficioRepository : IBeneficioRepository
    {
        private FabricaContext _context;

        public BeneficioRepository(FabricaContext context)
        {
            _context = context;
        }

        public IList<Beneficio> BuscarPor(Expression<Func<Beneficio, bool>> filtro)
        {
           return _context.Beneficios.Where(filtro).ToList();
        }

        public IList<Beneficio> BuscarPorFuncionario(int id)
        {
            // o select define o retorno da pesquisa, no cado o objeto Beneficio
            return _context.FuncionarioBeneficios.Where(f => f.FuncionarioId == id).Select(f => f.Beneficio).ToList();
        }

        public void Cadastrar(Beneficio bens)
        {
            _context.Beneficios.Add(bens);
        }

        public void Commitar()
        {
            _context.SaveChanges();
        }

        public IList<Beneficio> Listar()
        {
           return _context.Beneficios.ToList();
        }

        // ainda precisa ser criado e implementado na view
        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
