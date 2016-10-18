using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Author
            {
        #region
        [Key]
        public int ID { get; set; }
        public string FirstNames { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        #endregion
    }
}
