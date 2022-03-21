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
        private readonly IContatoRepositiorio _contatoRepositorio;
        public HomeController(IContatoRepositiorio contatoRepositiorio)
        {
            _contatoRepositorio = contatoRepositiorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CriarContato()
        {
            return View();
        }

        public IActionResult EditarContato()
        {
            return View();
        }

        public IActionResult ApagarContato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }
    }
}
