using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Repository.DataSeeding
{
    public static class daniaSeed
    {
        public static EntityTypeBuilder<dania> Seed(this EntityTypeBuilder<dania> entityTypeBuilder)
        {
            entityTypeBuilder.HasData(new dania()
            {
                id = 1,
                typ = 1,
                nazwa = "Barszcz",
                cena = 25
            });
            entityTypeBuilder.HasData(new dania()
            {
                id = 2,
                typ = 3   ,
                nazwa = "Sałatka",
                cena = 15
            });
            entityTypeBuilder.HasData(new dania()
            {
                id = 3,
                typ = 1,
                nazwa = "Rosół",
                cena = 20
            });
            entityTypeBuilder.HasData(new dania()
            {
                id = 4,
                typ = 1,
                nazwa = "Schabowy",
                cena = 17
            });
            entityTypeBuilder.HasData(new dania()
            {
                id = 5,
                typ = 4,
                nazwa = "Lody",
                cena = 5
            });
            entityTypeBuilder.HasData(new dania()
            {
                id = 6,
                typ = 3,
                nazwa = "Spagetti",
                cena = 20
            });
            entityTypeBuilder.HasData(new dania()
            {
                id = 7,
                typ = 1,
                nazwa = "fdgd",
                cena = 25
            });
            entityTypeBuilder.HasData(new dania()
            {
                id = 8,
                typ = 2,
                nazwa = "sfbdg",
                cena = 15
            });
            entityTypeBuilder.HasData(new dania()
            {
                id = 9,
                typ = 5,
                nazwa = "Sok",
                cena = 10
            });
            return entityTypeBuilder;
        }
    }
}
