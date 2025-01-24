using Microsoft.EntityFrameworkCore;
using WebApp.Domain;
using WebApp.Repository.DataSeeding;

namespace WebApp.Repository.DbContexts
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }

        DbSet<Product> Products { get; set; }
        DbSet<Ksiazka> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ksiazka>().Seed();
            modelBuilder.Entity<Product>().Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
