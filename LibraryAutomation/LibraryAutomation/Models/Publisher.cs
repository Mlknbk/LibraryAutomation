using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    public class Publisher:BaseEntity
    {
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }

        public List<Book> Books { get; set; }
    }
}
