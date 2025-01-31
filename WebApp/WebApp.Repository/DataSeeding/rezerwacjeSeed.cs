using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Repository.DataSeeding
{
    public static class rezerwacjeSeed
    {
        public static EntityTypeBuilder<rezerwacje> Seed(this EntityTypeBuilder<rezerwacje> entityTypeBuilder, DateTime data_rez)
        {
            entityTypeBuilder.HasData(new rezerwacje()
            {
                id = 1,
                nr_stolika = 1,
                data_rez = 24 - 12 - 2025,
                liczba_osob = 10,
                telefon = "483027542"
            });
            entityTypeBuilder.HasData(new rezerwacje()
            {
                id = 2,
                nr_stolika = 5,
                data_rez = 15 - 04 - 2033,
                liczba_osob = 7,
                telefon = "111111111"
            });
            entityTypeBuilder.HasData(new rezerwacje()
            {
                id = 3,
                nr_stolika = 16,
                data_rez = 09 - 05 - 2025,
                liczba_osob = 20,
                telefon = "098567425"
            });
            return entityTypeBuilder;
        }
    }
}
