using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }

        public string EmailAddress  { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
                  
     }
}
