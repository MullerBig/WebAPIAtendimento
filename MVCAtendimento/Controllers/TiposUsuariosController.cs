using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCAtendimento.Interfaces;
using MVCAtendimento.Models;
using MVCAtendimento.Repositorio;

namespace MVCAtendimento.Controllers
{
    public class TiposUsuariosController : Controller
    {
        private readonly ITipoUsuario _ITipoUsuario;
        public TiposUsuariosController(ITipoUsuario ITipoUsuario)
        {
            _ITipoUsuario = ITipoUsuario;
        }

        // GET: TiposUsuariosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TiposUsuariosController/Details/5
        public ActionResult Details(int id)
        {
            return View(_ITipoUsuario.SelecionarTipoUsuario(id));
        }

        // GET: TiposUsuariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposUsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoUsuario collection)
        {
            try
            {
                _ITipoUsuario.CriarTipoUsuario(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TiposUsuariosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_ITipoUsuario.SelecionarTipoUsuario(id));
        }

        // POST: TiposUsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TipoUsuario collection)
        {
            try  
            {
                _ITipoUsuario.AtualizarTipoUsuario(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TiposUsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_ITipoUsuario.SelecionarTipoUsuario(id));
        }

        // POST: TiposUsuariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _ITipoUsuario.DeletarTipoUsuario(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
