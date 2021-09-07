using Fiap.Aula.Web.Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula.Web.Exemplo01.Controllers
{
    public class ProdutoController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] // abrir na pagina do formulario e recuperar as informações
        public IActionResult Cadastro()
        {
            return View();
        }

        // Ctrl + M + G -> navega para a View criada
        [HttpPost] // efetuar o formulario ao a
        public IActionResult Cadastro(Produto produto)
        {
            //Enviar informaçõs para a View , perde os dados no redirect
            ViewData["nome"] = produto.Nome;
            ViewData["preco"] = produto.Preco;

            ViewBag.prod = produto;
            ViewBag.qtd = produto.Quantidade;
            ViewBag.name = produto.Nome;

            //Enviar informaçõs para a View , mantem os dados no redirect
            TempData["msg"] = "Produto enviado com sucesso";
            TempData["nome"] = produto.Nome;

            return RedirectToAction("Cadastro"); // Redirect -> Realiza uma nova requisição para enviar novos dados ao recarregar a pagina
            //return View(); forward -> Permanece a mesma requisição ainda continua no browser, assim pode gerar dados duplicados no banco
           // return Content($"Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade: {produto.Quantidade}");
        }
        /*
         * Criar um Action que entenda a URL ./produto/cadastrar
         * Abrir um página com um formulario: nome, preço, quantidade, botao
         */
    }
}
