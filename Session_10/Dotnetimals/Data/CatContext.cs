using Microsoft.EntityFrameworkCore;

namespace Dotnetimals
{
    public class CatContext : DbContext
    {
        public CatContext(DbContextOptions<CatContext> options) : base(options)
        {
            
        }

        public DbSet<Cat> Cats {get; set;}
        public DbSet<Order> Orders { get; set; }
    }
}