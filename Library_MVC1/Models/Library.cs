using System;
using System.Data.Entity;

namespace Library_MVC1.Models
{
    public class Library
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        //public string Author { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class LibraryDBContext : DbContext
    {
        public DbSet<Library> Libraries { get; set; }
    }

}