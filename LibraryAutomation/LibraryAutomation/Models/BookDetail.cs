using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    public class BookDetail:BaseEntity
    {
        public string Overview { get; set; }
        public int PageNumber { get; set; }
        public DateTime PublishingYear { get; set; }

        public Book Book { get; set; }
    }
}
