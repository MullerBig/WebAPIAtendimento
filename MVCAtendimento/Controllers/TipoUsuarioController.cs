using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;
using MVCAtendimento.Context;
using MVCAtendimento.Models;

namespace MVCAtendimento.Controllers
{
    public class TipoUsuarioController : Controller
    {
        private readonly SCContext _context;

        public TipoUsuarioController(SCContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tipousuarios= _context.TipoUsuarios.ToList();
            return View(tipousuarios);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(TipoUsuario tipousuario)
        {
            if (ModelState.IsValid)
            {
                _context.TipoUsuarios.Add(tipousuario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(tipousuario);
        }

        public IActionResult Editar (int id)
        {
            var tipousuario = _context.TipoUsuarios.Find(id);

            if (tipousuario == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Editar(TipoUsuario tipousuario)
        {
            var tipousuarioBanco = _context.TipoUsuarios.Find(tipousuario.TipoUsuarioId);

            tipousuarioBanco.Descricao = tipousuario.Descricao;

            _context.TipoUsuarios.Update(tipousuarioBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var tipousuario = _context.TipoUsuarios.Find(id);

            if (tipousuario == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(tipousuario);
        }

        public IActionResult Deletar(int id)
        {
            var tipousuario = _context.TipoUsuarios.Find(id);

            if (tipousuario == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(tipousuario);
        }

        [HttpPost]
        public IActionResult Deletar(TipoUsuario tipousuario)
        {
            var tipousuarioBanco = _context.TipoUsuarios.Find(tipousuario.TipoUsuarioId);
           
            _context.TipoUsuarios.Remove(tipousuarioBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
