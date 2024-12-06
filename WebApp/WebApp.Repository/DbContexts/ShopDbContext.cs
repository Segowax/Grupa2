using Microsoft.EntityFrameworkCore;
using WebApp.Domain;

namespace WebApp.Repository.DbContexts
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }

        DbSet<Product> Products { get; set; }
        DbSet<Ksiazka> Books { get; set; }
    }
}
