using FIAP.aula03.Web.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Repositories
{
    public interface IFuncionarioRepository
    {
        void Cadastrar(Funcionario func);

        void Atualizar(Funcionario func);

        void Remover(int id);

        IList<Funcionario> Listar();

        Funcionario BuscarPorId(int id);

        IList<Funcionario> BuscarPor(Expression<Func<Funcionario, bool>> filtro);

        void Commitar();
    }
}
