using FIAP.aula03.Web.Entity.Models;
using FIAP.aula03.Web.Entity.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Repositories
{
    public class FuncBeneficioRepository : IFuncBeneficioRepository
    {
        private FabricaContext _context;

        public FuncBeneficioRepository(FabricaContext context)
        {
            _context = context;
        }
        public void Cadastrar(FuncionarioBeneficio funcBeneficio)
        {
            _context.FuncionarioBeneficios.Add(funcBeneficio);
        }


        public void Commitar()
        {
            _context.SaveChanges();
        }
    }
}
