using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public BookType BookType { get; set; }
        public BookDetail BookDetail { get; set; }
        public List<Transaction> Transactions { get; set; }

        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public int BookTypeID { get; set; }
        public int BookDetailID { get; set; }

    }
}
