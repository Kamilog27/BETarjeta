using BETarjetaCredito.Models;
using Microsoft.EntityFrameworkCore;

namespace BETarjetaCredito
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<TarjetaCredito> TarjetaCreditos { get; set; }
    }
}
