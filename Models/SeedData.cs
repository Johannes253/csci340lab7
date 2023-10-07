using Microsoft.EntityFrameworkCore;
using RazorPagesCountry.Data;

namespace RazorPagesCountry.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesCountryContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesCountryContext>>()))
        {
            if (context == null || context.Country == null)
            {
                throw new ArgumentNullException("Null RazorPagesCountryContext");
            }

            // Look for any movies.
            if (context.Country.Any())
            {
                return;   // DB has been seeded
            }

            context.Country.AddRange(
                new Country
                {
                    Name = "Germany",
                    FormationDate = DateTime.Parse("1989-10-12"),
                    BestFood = "Weißwurst",
                    PopulationinMillion = 85.99M
                },

                new Country
                {
                    Name = "Croatia",
                    FormationDate = DateTime.Parse("1990-2-12"),
                    BestFood = "Something from Croatia probably",
                    PopulationinMillion = 4.99M
                },

                new Country
                {
                    Name = "European Union",
                    FormationDate = DateTime.Parse("2030-2-12"),
                    BestFood = "Schnitzel",
                    PopulationinMillion = 700.99M
                }
            );
            context.SaveChanges();
        }
    }
}