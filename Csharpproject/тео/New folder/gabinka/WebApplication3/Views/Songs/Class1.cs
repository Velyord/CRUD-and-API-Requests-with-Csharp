using System;
using System.Data.Entity;

namespace MvcSongs.Models
{
    public class Songs
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class SongsDBContext : DbContext
    {
        public DbSet<Songs> Songs { get; set; }
    }
 
}