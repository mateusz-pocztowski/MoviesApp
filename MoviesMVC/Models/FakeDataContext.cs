using Microsoft.EntityFrameworkCore;
using Movies.Models;

namespace MoviesMVC.Models
{
    public class FakeContext : DbContext
    {
        public FakeContext(DbContextOptions<FakeContext> options)
            : base(options)
        {
        }

        public DbSet<MovieItem> Movies { get; set; }

        public DbSet<Movies.Models.MovieItem> MovieItem{ get; set; }
    }
}
