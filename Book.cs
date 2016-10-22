using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// Definition of a book
    /// 
    /// </summary>
   public class Book
    {
        #region Properties
        /// <summary>
        /// ISBN of the book
        /// </summary>
        [Key]
        public int ISBN { get; set; }
        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title { get; set; }

        public DateTime PublishedYear { get; set; }
        public decimal Price     { get; set; }
        public int Count { get; set; }

        [ForeignKey("Author")]
        public int AuthorID { get; set; }

        public virtual Author Author { get; set; }
        #endregion

        #region Methods
        public void Checkout()
        {
          Count--;
        }
        public void Return()
        {
            Count++;

        }


        #endregion
    }
}
