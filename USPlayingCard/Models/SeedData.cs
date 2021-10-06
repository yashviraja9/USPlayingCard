using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using USPlayingCard.Data;

namespace USPlayingCard.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new USPlayingCardContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<USPlayingCardContext>>()))
            {
                // Look for any cards.
                if (context.Card.Any())
                {
                    return;   // DB has been seeded
                }

                context.Card.AddRange(
                    new Card
                    {
                        Title = "Bicycle Standard Face Playing Cards",
                        Brand = "Bicycle",
                        Material = "Double Weave",
                        Price = 12.49M,
                        Rating = "3"
                    },
                    new Card
                    {
                        Title = "Deck of 50 Fournier Spanish Playing Cards",
                        Brand = "Naipes Fournier",
                        Material = "Paper",
                        Price = 37.24M,
                        Rating = "4"       
                    },
                    new Card
                    {
                        Title = "Bee Jumbo Index Playing Cards",
                        Brand = "Bee",
                        Material = "Double knit fabric",
                        Price = 9.95M,
                        Rating = "2"
                    },
                    new Card
                    {
                        Title = "Tally - Ho Circle Back Playing Cards",
                        Brand = "Tally Ho",
                        Material = "Wooden",
                        Price = 17.39M,
                        Rating = "5"
                    },
                    new Card
                    {
                        Title = "Congress Sunflower Playing Cards",
                        Brand = "Congress",
                        Material = "Plastic",
                        Price = 21.15M,
                        Rating = "1"
                    },
                    new Card
                    {
                        Title = "Hoyle Slice Playing Cards",
                        Brand = "Hoyle",
                        Material = "Plastic",
                        Price = 19.95M,
                        Rating = "2"
                    },
                    new Card
                    {
                        Title = "Aviator Heritage Playing Cards",
                        Brand = "Aviator",
                        Material = "Elasticized-Fabric",
                        Price = 13.95M,
                        Rating = "3"
                    },
                     new Card
                     {
                         Title = "Artisan Playing Cards",
                         Brand = "Artisan",
                         Material = "Paper",
                         Price = 13.95M,
                         Rating = "4"
                     },
                      new Card
                      {
                          Title = "Streamline Jumbo Index Playing Cards",
                          Brand = "Bicycle",
                          Material = "Diamond",
                          Price = 36.99M,
                          Rating = "5"
                      },
                       new Card
                       {
                           Title = "KEM Arrow Jumbo Index Playing Cards",
                           Brand = "Springbok",
                           Material = "Rubber",
                           Price = 34.95M,
                           Rating = "1"
                       }
                );
                context.SaveChanges();
            }
        }
    }
}
