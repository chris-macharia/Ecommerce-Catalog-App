using Microsoft.EntityFrameworkCore;

namespace EcommerceCatalog.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Create a Products table
        public DbSet<Product> Products { get; set; }
    }
}
