using Microsoft.EntityFrameworkCore;
using WebAPIAtendimento.Entities;

namespace WebAPIAtendimento.Context
{
    public class SCContext : DbContext
    {
        public SCContext(DbContextOptions<SCContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
    }
}
