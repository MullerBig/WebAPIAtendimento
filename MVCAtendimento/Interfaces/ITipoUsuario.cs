using Microsoft.AspNetCore.Mvc;
using MVCAtendimento.Models;


namespace MVCAtendimento.Interfaces
{
    public interface ITipoUsuario
    {
        TipoUsuario CriarTipoUsuario(TipoUsuario tipousuario);

        TipoUsuario SelecionarTipoUsuario(int TipoUsuarioId);

        TipoUsuario AtualizarTipoUsuario(int TipoUsuarioId, TipoUsuario tipousuario);

        TipoUsuario DeletarTipoUsuario(int TipoUsuarioId);
        void AtualizarTipoUsuario(TipoUsuario collection);
    }
}
