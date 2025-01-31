using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Repository.DataSeeding
{
    public static class pracownicySeed
    {
        public static EntityTypeBuilder<pracownicy> Seed(this EntityTypeBuilder<pracownicy> entityTypeBuilder)
        {
            entityTypeBuilder.HasData(new pracownicy()
            {
                id = 1,
                imie = "Konrad",
                nazwisko = "Nowak",
                stanowisko = 1
            });
            entityTypeBuilder.HasData(new pracownicy()
            {
                id = 2,
                imie = "Maja",
                nazwisko = "dopensjon",
                stanowisko = 2
            });
            entityTypeBuilder.HasData(new pracownicy ()
            {
                id = 3,
                imie = "Tomek",
                nazwisko = "Fyjslag",
                stanowisko = 1
            });
            return entityTypeBuilder;
        }
    }
}
