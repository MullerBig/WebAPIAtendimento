using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;
using MVCAtendimento.Models;
using MVCAtendimento.Context;

namespace MVCAtendimento.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly SCContext _context;

        public UsuarioController(SCContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var usuarios = _context.Usuarios.ToList();
            return View(usuarios);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));            
            }
            return View(usuario);
        }

    }
}
