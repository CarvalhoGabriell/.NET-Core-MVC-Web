using FIAP.aula03.Web.Entity.Models;
using FIAP.aula03.Web.Entity.Persistencia;
using Microsoft.AspNetCore.Mvc;
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


        // o sinal de ? atribui nulo ao parametro pré setado
        [HttpGet]
        public IActionResult Index(string nomeBuscado, Genero? genBuscado)
        {
           
            var busca = _context.Funcionarios.Where(
                str => (str.Nome.Contains(nomeBuscado) || nomeBuscado == null ) && 
                (genBuscado == str.Genero || genBuscado == null)).ToList();
            return View(busca);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
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
            var func = _context.Funcionarios.Find(id);
            
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
