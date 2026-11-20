using Microsoft.EntityFrameworkCore;

namespace sitio1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Medico> Medicos { get; set; }
    }
}