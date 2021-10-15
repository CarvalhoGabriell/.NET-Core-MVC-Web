using Fiap.CP_1.SofiaBag.Models;
using Fiap.CP_1.SofiaBag.Persistencia;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.CP_1.SofiaBag.Controllers
{
    public class UsuarioController : Controller
    {
        private MochilaContext _context;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario user)
        {

            return RedirectToAction("Cadastrar");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            return View("index");
        }
    }
}
