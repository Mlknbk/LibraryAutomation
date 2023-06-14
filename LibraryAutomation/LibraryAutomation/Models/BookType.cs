using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    public class BookType:BaseEntity
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }

    


    }
}
