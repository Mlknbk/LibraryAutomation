using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    public class Author:BaseEntity
    {
        public string UserName { get; set; }
        public string LastName { get; set; }

        public List<Book> Books { get; set; }
        
    }
}
