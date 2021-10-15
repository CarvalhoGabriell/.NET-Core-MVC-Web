using FIAP.aula03.Web.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Repositories
{
    public interface IFuncBeneficioRepository
    {
        void Cadastrar(FuncionarioBeneficio funcBeneficio);

        void Commitar();
    }
}
