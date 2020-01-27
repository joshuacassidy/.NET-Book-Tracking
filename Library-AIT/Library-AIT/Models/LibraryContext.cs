using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Library_AIT.Models
{
    public class LibraryContext : DbContext
    {

        public LibraryContext() : base("LibraryContext")
        {

        }


        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }


    }
}