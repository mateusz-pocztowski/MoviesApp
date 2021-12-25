using Microsoft.EntityFrameworkCore;

namespace Movies.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }
        public DbSet<MovieItem> MovieItems { get; set; }
    }
}