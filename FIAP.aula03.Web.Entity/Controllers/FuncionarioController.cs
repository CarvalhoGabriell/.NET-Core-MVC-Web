using FIAP.aula03.Web.Entity.Models;
using FIAP.aula03.Web.Entity.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Controllers
{
    public class FuncionarioController : Controller
    {
        private FabricaContext _context;
        public FuncionarioController(FabricaContext context)
        {
            _context = context;        
        }

        private void CarregarDepartamentos()
        {
            // pesquisa todos os departamentos
           var lista = _context.Departs.OrderBy(d=> d.NomeDepart).ToList();

            // envia para a view as opçoes do select para selecionar 
            ViewBag.departamentos = new SelectList(lista, "DepartamentoId", "NomeDepart");
        }

        // o sinal de ? atribui nulo ao parametro pré setado
        // metodo responsavel pela pesquisas
        [HttpGet]
        public IActionResult Index(string nomeBuscado, Genero? genBuscado)
        {
           
            var busca = _context.Funcionarios.Where(
                str => (str.Nome.Contains(nomeBuscado) || nomeBuscado == null ) && 
                (genBuscado == str.Genero || genBuscado == null))
                .Include(f => f.Departamento)
                .Include(f => f.Endereco) // inclui um endereço no resultado da pesquisa
                .ToList();
            return View(busca);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarDepartamentos();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Funcionario func)
        {
            _context.Funcionarios.Add(func);
            _context.SaveChanges();
            TempData["msg"] = "Funcionario Cadastrado com Sucesso!";
           return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarDepartamentos();
            var func = _context.Funcionarios
                .Include(f => f.Endereco)
                .Include(f => f.Departamento)
                .Where(f => f.FuncionarioId == id)
                .FirstOrDefault();
            
            return View(func);
        }


        [HttpPost]
        public IActionResult Editar(Funcionario obj)
        {

            _context.Funcionarios.Update(obj);
            _context.SaveChanges();
            TempData["msg"] = "Funcionário Atualizado com Sucesso";
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            var func = _context.Funcionarios.Find(id);
            _context.Funcionarios.Remove(func);
            _context.SaveChanges();

            TempData["msg"] = "Funcionário Removido com sucesso";
            return RedirectToAction("Index");
        }

    }
}
