using Fiap.CP_1.SofiaBag.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.CP_1.SofiaBag.Controllers
{
    public class ObjetoController : Controller
    {
        private static List<Objetos> _banco = new List<Objetos>();
        private static int _generator = 1;

        [HttpGet]
        public IActionResult Index()
        {
            return View(_banco);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarCores();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Objetos obj)
        {
            obj.Codigo = _generator++;
            _banco.Add(obj);
            TempData["msg"] = "Objeto Cadastrado com Sucesso!";
            return RedirectToAction("Cadastrar");
        }
        
        [HttpPost]
        public IActionResult Deletar(int id) 
        {
            // Metodo para procurar na lista de objetos cadastrados (Banco de Dados) e remover
            _banco.RemoveAll(num => num.Codigo == id);

            TempData["msg"] = "Objeto Removido com Sucesso";
            return RedirectToAction("Index");
        }

        [HttpGet] // metodo responsavel para direcionar para a tela de edição com os dados do objeto clicado
        public IActionResult Editar(int id)
        {
            CarregarCores();
            // apos no clique no botao "editar" no objeto da tabela esse metodo irá procurar ele na lista de objetos (banco de dados)
            var objeto = _banco.Find(num => num.Codigo == id);
            return View(objeto);
        }

        [HttpPost]
        public IActionResult Editar(Objetos objs)
        {
            _banco[_banco.FindIndex(num => num.Codigo == objs.Codigo)] = objs;
            TempData["msg"] = "Objeto Editado com Sucesso!";
            TempData["rfid"] = objs.Codigo;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Pesquisar(string searchName)
        {
            //var nomes = from m in _banco select m;
            if ( !String.IsNullOrEmpty(searchName))
            {
                //nomes = nomes.Where(str => str.Nome.Contains(nomePesquisado));
               var search = _banco.Where(str => str.Nome.Contains(searchName));

                return View(search);
            }
            return View("Index");
        }
   


        public void CarregarCores()
        {
            var listaCores = new List<string>(new string[]
            { "Vermelho","Azul", "Amarelo", "Verde", "Rosa", "Lilás", "Preto", "Roxa", "Branco", "Marrom",
                "Rosa-Pink", "Laranja", "Cinza", "Prateado", "Dourado","Verde-Escuro", "Violeta", "Azul-Claro", "Azul-Marinho"});
            ViewBag.cores = new SelectList(listaCores);
        }
    }
}
