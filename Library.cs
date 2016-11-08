using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public enum RentalTypes
    {
        Book,
        Audio,
        Video
    }
   public static class Library
    {
    
        #region Properties
        public static string Name { get; set; }
        public static string Address { get; set; }
        /// <summary>
        ///  Collection of books
        /// </summary>

        public static List<Book> Books { get; set; }
        #endregion

        #region Constructors
        static Library()
        {
            Books = new List<Book>();
        }
        #endregion


        #region Methods
        public static void AddBook(Book book)
        {
            using (var model = new LibraryModel())
            {
                model.Books.Add(book);
                model.SaveChanges();  
           }
                
        }
        public static void PrintBooks()
        {
            using (var model = new LibraryModel())
            {
                foreach (var book in model.Books)
                {
                    Console.WriteLine("Title: {0}, ISBN: {1}, Price: {2}, Published: {3}",
                        book.Title, book.ISBN, book.Price, book.PublishedYear);


                }


            }
        }
        #endregion
    }
}
