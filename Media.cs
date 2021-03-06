﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Media
    {
        #region Properties
        [Key]
        public  int ID { get; set; }    
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime PublishedYear { get; set; }
        public decimal Price { get; set; }
        public int Copies { get; set; }
        #endregion
    }
}
