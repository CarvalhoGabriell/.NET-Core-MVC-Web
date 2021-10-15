using FIAP.aula03.Web.Entity.Models;
using FIAP.aula03.Web.Entity.Persistencia;
using FIAP.aula03.Web.Entity.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity.Controllers
{
    public class FuncionarioController : Controller
    {
        private IFuncBeneficioRepository _funcBeneficioRepository;

        private IFuncionarioRepository _funcRepository;

        private IDepartamentoRepository _departamentoRepository;

        private IBeneficioRepository _beneficioRepository;


        public FuncionarioController(IBeneficioRepository beneficioRepository, 
            IFuncionarioRepository funcRepository, 
            IDepartamentoRepository departamentoRepository,
            IFuncBeneficioRepository funcBeneficio)
        {
            _funcBeneficioRepository = funcBeneficio;
            _departamentoRepository = departamentoRepository;
            _funcRepository = funcRepository;
            _beneficioRepository = beneficioRepository;        
        }

        private void CarregarDepartamentos()
        {
            // pesquisa todos os departamentos
            var lista = _departamentoRepository.Listar();

            // envia para a view as opçoes do select para selecionar 
            ViewBag.departamentos = new SelectList(lista, "DepartamentoId", "NomeDepart");
        }

        [HttpPost]
        public IActionResult Detalhes(FuncionarioBeneficio funcBeneficio)
        {
            _funcBeneficioRepository.Cadastrar(funcBeneficio);
            _funcBeneficioRepository.Commitar();
            TempData["msg"] = "Beneficio Associado com sucesso!";

            return RedirectToAction("Detalhes", new{ id= funcBeneficio.FuncionarioId});
        }

        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            var funcionario = _funcRepository.BuscarPorId(id);

            // pesquisar todos beneficios disponiveis cadastrados
            var allBeneficios = _beneficioRepository.BuscarPor(b => b.Disponivel);

            // pesquisar beneficios associados ao funcionario
            var beneficioFunc = _beneficioRepository.BuscarPorFuncionario(id);

            // lista filtrada mostrando todos os beneficios que não estao associados a um funcionario
            var listaFiltro = allBeneficios.Where(b => !beneficioFunc.Any(b1 => b1.BeneficioId == b.BeneficioId));

            ViewBag.beneficiosSelect = new SelectList(listaFiltro, "BeneficioId", "Nome");
            
            ViewBag.beneficios = beneficioFunc;
            
            return View(funcionario);
        }

        // o sinal de ? atribui nulo ao parametro pré setado
        // metodo responsavel pela pesquisas
        [HttpGet]
        public IActionResult Index(string nomeBuscado, Genero? genBuscado)
        {
           
            var busca = _funcRepository.BuscarPor(
                str => (str.Nome.Contains(nomeBuscado) || nomeBuscado == null ) && 
                (genBuscado == str.Genero || genBuscado == null));
            return View(busca);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarDepartamentos();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Funcionario func)
        {
            _funcRepository.Cadastrar(func);
            _funcRepository.Commitar();
            TempData["msg"] = "Funcionario Cadastrado com Sucesso!";
           return RedirectToAction("Detalhes", new { id = func.FuncionarioId});
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarDepartamentos();
            var func = _funcRepository.BuscarPorId(id);
            
            return View(func);
        }


        [HttpPost]
        public IActionResult Editar(Funcionario obj)
        {

            _funcRepository.Atualizar(obj);
            _funcRepository.Commitar();
            TempData["msg"] = "Funcionário Atualizado com Sucesso";
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            _funcRepository.Remover(id);
            _funcRepository.Commitar();

            TempData["msg"] = "Funcionário Removido com sucesso";
            return RedirectToAction("Index");
        }

    }
}
