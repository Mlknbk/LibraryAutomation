using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    public class Account:BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }


        public Admin Admin { get; set; }
        public User User { get; set; }
    }
}
