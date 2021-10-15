using FIAP.aula03.Web.Entity.Models;
using FIAP.aula03.Web.Entity.Persistencia;
using FIAP.aula03.Web.Entity.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Controllers
{
    public class DepartamentoController : Controller
    {
        private IDepartamentoRepository _departsRepository;

        public DepartamentoController (IDepartamentoRepository departsrespository)
        {
            _departsRepository = departsrespository;
           
        }

        [HttpGet]
        public IActionResult Index()
        {
            var lista = _departsRepository.Listar();
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
            _departsRepository.Cadastrar(depart);
            _departsRepository.Commitar();
            TempData["msg"] = "Departamento cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

        [HttpPost]
        public IActionResult Deletar(int id)
        {
            _departsRepository.Remover(id);
            _departsRepository.Commitar();
            TempData["msg"] = "Departamento Removido!";
            return RedirectToAction("Index");
        }
    }
}
