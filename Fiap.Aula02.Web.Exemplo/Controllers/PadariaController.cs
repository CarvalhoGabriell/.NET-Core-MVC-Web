using Fiap.Aula02.Web.Exemplo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula02.Web.Exemplo.Controllers
{
    public class PadariaController : Controller
    {
        private static List<Padaria> _banco = new List<Padaria>();
        private static int _genador = 1;

        [HttpGet]
        // Carrega a view Index da Padaria, URL -> /Padaria ou /Padaria/index
        public IActionResult Index()
        {
            //Viewbag._banco
            return View(_banco);
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _banco.RemoveAll( num => num.Codigo == id);

            // Remover pelo index procurado
            //_banco.RemoveAt(_banco.FindIndex(num => num.Codigo == id));
            TempData["msg"] = "Padaria Removida !!";

            return RedirectToAction("index");
        }

        [HttpPost] // metodo responsavel para atualizar as informações quando apertar o botao "Editar"
        public IActionResult Editar(Padaria padoca)
        {
            // atualizar com os dados novos informados
            _banco[ _banco.FindIndex(num => num.Codigo == padoca.Codigo)] = padoca;
            TempData["msg"] = "Padaria Editada com Sucesso!";

            return RedirectToAction("Index");
        }

        [HttpGet]// abre a pagina de edição com os dados da padaria cadastrada
        public IActionResult Editar(int id)
        {
            CarregarCidades();
            // pesquisar uma padaria pelo codigo
            var padaria = _banco.Find(num => num.Codigo == id);

            // enviar para a view o objeto completo 
            return View(padaria);
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            CarregarCidades();
            return View();
        }

        [HttpPost]// enviar o formulario preenchido para cadastrar.
        public IActionResult Cadastro(Padaria padoca)
        {
            padoca.Codigo = _genador++;
            _banco.Add(padoca);
            TempData["msg"] = "Padaria Cadastrada com Sucesso!";
            return RedirectToAction("Cadastro");
   
        }
        // metodo statico que envia a lista  de cidades para carregar as opçoes do select
        private void CarregarCidades()
        {
            var lista = new List<string>(new string[] { "São Paulo", "Rio de Janeiro", "Maceió", "Curitiba", "Fortaleza" });
            ViewBag.cidades = new SelectList(lista);
        }
    }
}
