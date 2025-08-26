using Microsoft.EntityFrameworkCore;

namespace EcommerceCatalog.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // We'll add DbSets here later
    }
}
