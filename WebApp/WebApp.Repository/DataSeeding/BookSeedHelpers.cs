using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Domain;

internal static class BookSeedHelpers
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