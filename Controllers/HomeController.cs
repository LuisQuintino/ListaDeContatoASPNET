using ListaDeContatoASPNET.Models;
using ListaDeContatoASPNET.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDeContatos.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public HomeController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.GetContatoList().ToList();
            return View(contatos);
        }

        public IActionResult CriarContato()
        {
            return View();
        }

        public IActionResult EditarContato(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult ApagarContato(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagar  = _contatoRepositorio.Apagar(id);

                if (apagar)
                {
                    TempData["Sucesso"] = "Contato apagado com sucesso";
                }
                else
                {
                    TempData["Erro"] = $"Houve um erro na hora de apagar o contato";
                }
                return RedirectToAction("Index");
            }
            catch (Exception  error)
            {
                TempData["Erro"] = $"Houve um erro na hora de apagar o contato, erro:{error.Message}";
                return RedirectToAction("Index");
            }
            

        }
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Adicionar(contato);
                    TempData["Sucesso"] = "Contato gravado com sucesso";
                    return RedirectToAction("Index");
                }
                return View("CriarContato");
            }
            catch (Exception error)
            {
                TempData["Erro"] = $"Houve um erro na hora de cadastrar o contato, erro:{error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Atualizar(contato);
                    TempData["Sucesso"] = "Contato editado com sucesso";
                    return RedirectToAction("Index");
                }
                return View("EditarContato", contato);
            }
            catch (Exception error)
            {
                TempData["Erro"] = $"Houve um erro na hora de editar o contato, erro:{error.Message}";
                throw;
            }
        }
    }
}
