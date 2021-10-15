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
    public class BeneficioController : Controller
    {
        private IBeneficioRepository _beneficioRepository;

        public BeneficioController(IBeneficioRepository beneficioRepository)
        {
            _beneficioRepository = beneficioRepository;                    
        }

        public IActionResult Index()
        {
            ViewBag.beneficios = _beneficioRepository.Listar();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Beneficio bens)
        {
            _beneficioRepository.Cadastrar(bens);
            _beneficioRepository.Commitar();
            TempData["msg"] = "Beneficio Registrado!";

            return RedirectToAction("Index");
        }

        /*
         * fazer o metodo que faça a remoção do beneficio
         */
    }
}
