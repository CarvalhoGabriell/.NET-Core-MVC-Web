using FIAP.aula03.Web.Entity.Models;
using FIAP.aula03.Web.Entity.Persistencia;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Controllers
{
    public class DepartamentoController : Controller
    {
        private FabricaContext _context;

        public DepartamentoController (FabricaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var lista = _context.Departs.ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Departamento depart)
        {
            _context.Departs.Add(depart);
            _context.SaveChanges();
            TempData["msg"] = "Departamento cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

        [HttpPost]
        public IActionResult Deletar(int id)
        {
            var depart = _context.Departs.Find(id);
            _context.Departs.Remove(depart);
            _context.SaveChanges();
            TempData["msg"] = "Departamento Removido!";
            return RedirectToAction("Index");
        }
    }
}
