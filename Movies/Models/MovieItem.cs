using System;

namespace Movies.Models
{
    public class MovieItem
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Rating { get; set; }
        public string Director { get; set; }
    }
}