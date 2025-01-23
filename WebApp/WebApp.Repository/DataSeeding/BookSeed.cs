using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Repository.DataSeeding
{
     public static class BookSeed
    {
        public static EntityTypeBuilder<Ksiazka> Seed(this EntityTypeBuilder<Ksiazka> entityTypeBuilder) 
        {
            entityTypeBuilder.HasData(new Ksiazka()
            {
                Id = 1,
                Tytul = "MeineKaumpf",
                Autor = "Adolf",
                Kategoria = 1,
                Guid = Guid.NewGuid()
            });
            entityTypeBuilder.HasData(new Ksiazka()
            {
                Id = 2,
                Tytul = "MeineKaumpf",
                Autor = "Adolf",
                Kategoria = 1,
                Guid = Guid.NewGuid()
            });
            return entityTypeBuilder;
        }
        
    }
}
