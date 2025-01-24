using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Domain;

namespace WebApp.Repository.DataSeeding
{

    public static class ProductSeed
    {
        public static EntityTypeBuilder<Product> Seed(this EntityTypeBuilder<Product> entityTypeBuilder)
        {
            entityTypeBuilder.HasData(new Product()
            {
                Id = 1,
                Name = "Name",
                Description = "Description",               
                Guid = Guid.NewGuid()
            });
            entityTypeBuilder.HasData(new Product()
            {
                Id = 2,
                Name = "Mimi",
                Description = "Description",
                Guid = new Guid("814dde23-05d8-4fab-87a7-00d0f305e315")
            });
            entityTypeBuilder.HasData(new Product()
            {
                Id = 3,
                Name = "ututut",
                Description = "Description",
                Guid = Guid.NewGuid()
            });
            return entityTypeBuilder;
        }
    }
}
