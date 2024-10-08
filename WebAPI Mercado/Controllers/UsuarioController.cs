using Microsoft.AspNetCore.Mvc;
using WebAPI_Mercado.Context;
using WebAPI_Mercado.Entities;
namespace WebAPI_Mercado.Controllers

{
    [ApiController]
    [Route("[Controller]")]

    public class UsuarioController : ControllerBase
    {
        private readonly SCContext _context;
        public UsuarioController(SCContext context)
        {
            _context = context;
        }

        //Usuario

        [HttpPost("CriarUsuario")]
        public ActionResult CriarUsuario(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet("SelecionarUsuarioId")]
        public ActionResult SelecionarUsuario(int UsuarioId)
        {
            var usuario = _context.Usuarios.Find(UsuarioId);
                
                if (usuario == null)
                {
                return NotFound();
                }
                return Ok(usuario);
        }

        [HttpPut("AtualizarUsuario")]
        public ActionResult AtualizarUsuario(int UsuarioId, Usuario usuario)
        {
            var usuarioBanco = _context.Usuarios.Find(UsuarioId);
            if (usuarioBanco == null)
                return NotFound();
            usuarioBanco.Nome = usuario.Nome;
            usuarioBanco.AbreviacaoNome = usuario.AbreviacaoNome;
            usuarioBanco.Descricao = usuario.Descricao;
            usuarioBanco.TipoUsuarioId = usuario.TipoUsuarioId;

            _context.Usuarios.Update(usuarioBanco);
            _context.SaveChanges();

            return Ok(usuarioBanco);
            
        }

        [HttpDelete("DeletarUsuario")]
        public ActionResult DeletarUsuario(int UsuarioId)
        {
            var usuarioBanco = _context.Usuarios.Find(UsuarioId);
            if (usuarioBanco == null)
                return NotFound();
            _context.Usuarios.Remove(usuarioBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
