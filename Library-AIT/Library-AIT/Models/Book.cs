using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_AIT.Models
{
    public class Book
    {

        private List<Author> _authors;

        public Book()
        {
            _authors = new List<Author>();        
        }


        public int ID { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public virtual List<Author> Authors {
            get { return _authors; }
            set { _authors = value; }
        }
    }
}