using EfCore.Models;
using Microsoft.EntityFrameworkCore;


namespace EfCore.Data
{
    public class EfCoreDbContext : DbContext
    {
        public EfCoreDbContext(DbContextOptions<EfCoreDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
