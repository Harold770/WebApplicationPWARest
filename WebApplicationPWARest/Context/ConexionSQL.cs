
using Microsoft.EntityFrameworkCore;
using WebApplicationPWARest.Modelos;

namespace WebApplicationPWARest.Context
{
    public class ConexionSQL:DbContext
    {
        public ConexionSQL(DbContextOptions<ConexionSQL>options):base(options){

        }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}

