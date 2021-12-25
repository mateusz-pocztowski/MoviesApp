using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Movies.Models;
using System;
using System.Linq;

namespace Movies.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieContext>>()))
            {
                // Look for any movies.
                if (context.MovieItems.Any())
                {
                    return;   // DB has been seeded
                }

                context.MovieItems.AddRange(
                    new MovieItem
                    {
                        Title = "Ghostbusters: Afterlife",
                        ReleaseDate = DateTime.Parse("2021-11-19"),
                        Genre = "Adventure comedy",
                        Rating = 7.7M,
                        Director = "Jason Reitman"
                    },

                    new MovieItem
                    {
                        Title = "Finch",
                        ReleaseDate = DateTime.Parse("2021-11-05"),
                        Genre = "Adventure drama",
                        Rating = 6.9M,
                        Director = "Miguel Sapochnik"
                    },

                    new MovieItem
                    {
                        Title = "Interstellar",
                        ReleaseDate = DateTime.Parse("2014-11-07"),
                        Genre = "Adventure drama",
                        Rating = 8.6M,
                        Director = "Christopher Nolan"
                    },

                    new MovieItem
                    {
                        Title = "Casino Royale",
                        ReleaseDate = DateTime.Parse("2006-11-17"),
                        Genre = "Action",
                        Rating = 8.0M,
                        Director = "Martin Campbell"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}