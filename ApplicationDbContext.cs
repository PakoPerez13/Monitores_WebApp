using Microsoft.EntityFrameworkCore;
using Monitores_WebApp.Entities;

namespace Monitores_WebApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Monitors> Monitores { get; set; }
    }
}
