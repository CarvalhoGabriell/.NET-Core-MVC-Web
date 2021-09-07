using Fiap.Aula.Web.Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula.Web.Exemplo01.Controllers
{
    public class UsuarioController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario user)
        {
            TempData["msg"] = "Login com sucesso!";
            TempData["user"] = user.Email;
            return RedirectToAction("Cadastro", "Produto");
        }
    }
}
