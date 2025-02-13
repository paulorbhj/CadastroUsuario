using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using CadastroUsuario.Models;
using CadastroUsuario.Repositorio;

namespace CadastroUsuario.Controllers
{
    public class UsuarioController1 : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController1(IUsuarioRepositorio usuarioRepositorio)
        {
           _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario)
        {
            _usuarioRepositorio.Adicionar(usuario);

            return RedirectToAction("Index1");
        }

        public IActionResult Index1()
        {
            return View();
        }
    }
}
