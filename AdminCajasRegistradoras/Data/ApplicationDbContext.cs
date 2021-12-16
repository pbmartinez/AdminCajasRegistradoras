using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AdminCajasRegistradoras.Models;

namespace AdminCajasRegistradoras.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Caja> Cajas { get; set; } 
        public DbSet<ConfiguracionEncabezado> Encabezados { get; set; } 

    }
}