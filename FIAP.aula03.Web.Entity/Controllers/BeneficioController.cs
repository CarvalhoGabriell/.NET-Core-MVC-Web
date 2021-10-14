using FIAP.aula03.Web.Entity.Models;
using FIAP.aula03.Web.Entity.Persistencia;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Controllers
{
    public class BeneficioController : Controller
    {
        private FabricaContext _context;

        public BeneficioController(FabricaContext context)
        {
            _context = context;                    
        }

        public IActionResult Index()
        {
            ViewBag.beneficios = _context.Beneficios.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Beneficio bens)
        {
            _context.Beneficios.Add(bens);
            _context.SaveChanges();
            TempData["msg"] = "Beneficio Registrado!";

            return RedirectToAction("Index");
        }
    }
}
