using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Models
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
       
        public BaseEntity()
        {
            this.IsActive = true;
            this.CreatedAt = DateTime.Now;
        }
    }
}
