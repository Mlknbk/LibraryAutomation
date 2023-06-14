using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    public class Transaction:BaseEntity
    {
        public User User { get; set; }
        public Book Book { get; set; }
        public DateTime ReturnDate { get; set; }

        public int UserID { get; set; }
        public int BookID { get; set; }

    }
}
