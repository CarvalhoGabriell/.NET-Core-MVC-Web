using Fiap.Aula02.Web.Exemplo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exemplo.Controllers
{
    public class PadariaController : Controller
    {
        private static List<Padaria> _banco = new List<Padaria>();
        
        public IActionResult Index()
        {
            //Viewbag._banco
            return View(_banco);
        }

        [HttpGet]
        public IActionResult Cadastro()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Padaria padoca)
        {   
            _banco.Add(padoca);
            TempData["msg"] = "Padaria Cadastrada com Sucesso";
            return RedirectToAction("Cadastro");
   
        }
    }
}
