using Microsoft.EntityFrameworkCore;
using WebAPI_Mercado.Entities;

namespace WebAPI_Mercado.Context
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
