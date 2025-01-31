using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Repository.DataSeeding
{
     public static class localeSeed
    {
        public static EntityTypeBuilder<locale> Seed(this EntityTypeBuilder<locale> entityTypeBuilder) 
        {
            entityTypeBuilder.HasData(new locale()
            {
                id = 1,
                nazwa = "Dobra kuchnia",
                miasto = "Wrocław",
                ulica = "biszkoptów 5",
                numer = 344657632
            });
            entityTypeBuilder.HasData(new locale()
            {
                id = 2,
                nazwa = "Coś",
                miasto = "Poznań",
                ulica = "Starożytna 47",
                numer = 785054684
            });
            entityTypeBuilder.HasData(new locale()
            {
                id = 3,
                nazwa = "U Tomka",
                miasto = "Warszawa",
                ulica = "Familijna 31",
                numer = 829105749
            });
            return entityTypeBuilder;
        }
        
    }
}
