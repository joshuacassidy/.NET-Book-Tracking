using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_AIT.Models
{
    public class Author
    {

        public List<Book> _books;

        public Author()
        {
            _books = new List<Book>();
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Book> Books {
            get { return _books; }
            set { _books = value; }
        }

    }
}