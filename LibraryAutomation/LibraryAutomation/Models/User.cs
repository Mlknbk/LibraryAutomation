using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    public class User:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int AccountID { get; set; }


        public Account Account { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
