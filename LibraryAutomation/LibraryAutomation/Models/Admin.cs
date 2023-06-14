using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    public class Admin:BaseEntity
    {
        public Account Account { get; set; }

        public int AccountID { get; set; }
    }
}
