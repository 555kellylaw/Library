using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Rental
    {
        [Key]
        public int RentalID { get; set; }
        public RentalTypes RentalType { get; set; }

        public int ID { get; set; }
        [ForeignKey("Account")]
        public int AccountID { get; set; }
        public virtual Account Account { get; set; }

    }
}
