using FIAP.aula03.Web.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Repositories
{
    public interface IBeneficioRepository

    {
        void Cadastrar(Beneficio bens);

        IList<Beneficio> Listar();

        IList<Beneficio> BuscarPor(Expression<Func<Beneficio, bool>> filtro);

        IList<Beneficio> BuscarPorFuncionario(int id);
        void Commitar();

        void Remover(int id);
    }
}
