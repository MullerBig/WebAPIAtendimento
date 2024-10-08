using Microsoft.AspNetCore.Mvc;
using WebAPI_Mercado.Context;
using WebAPI_Mercado.Entities;

namespace WebAPI_Mercado.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class TipoUsuarioController : ControllerBase
    {
        private readonly SCContext _context;
        public TipoUsuarioController(SCContext context)
        {
            _context = context;
        }

        //TipoUsuario
        [HttpPost("CriarTipoUsuario")]
        public ActionResult CriarTipoUsuario(TipoUsuario tipousuario)
        {
            _context.Add(tipousuario);
            _context.SaveChanges();
            return Ok(tipousuario);
        }

        [HttpGet("SelecionarTipoUsuarioId")]
        public ActionResult SelecionarTipoUsuario(int TipoUsuarioId)
        {
            var tipousuario = _context.TipoUsuarios.Find(TipoUsuarioId);

            if (tipousuario == null)
            {
                return NotFound();
            }

            return Ok(tipousuario);
        }

        [HttpPut("AtualizarTipoUsuario")]
        public ActionResult AtualizarTipoUsuario(int TipoUsuarioId, TipoUsuario tipousuario)
        {
            var usuarioBanco = _context.TipoUsuarios.Find(TipoUsuarioId);
            if (usuarioBanco == null)
                return NotFound();
            usuarioBanco.Descricao = tipousuario.Descricao;

            _context.TipoUsuarios.Update(usuarioBanco);
            _context.SaveChanges();
            
            return Ok(usuarioBanco);
        }

        [HttpDelete("DeletarTipoUsuario")]
        public ActionResult DeletarTipoUsuario(int TipoUsuarioId)
        {
            var usuarioBanco = _context.TipoUsuarios.Find(TipoUsuarioId);
            if (usuarioBanco == null)
                return NotFound();
            _context.TipoUsuarios.Remove(usuarioBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}