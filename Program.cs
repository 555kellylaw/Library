using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Welcome to my library*******");
            int choice = -1;
            bool invalidChoice = false;

            while (choice != 0 || invalidChoice )
            { 
            Console.WriteLine("1. Add a book to the library");
            Console.WriteLine("2. Rent a book from the library");
            Console.WriteLine("3. Return a book to the library");
            Console.WriteLine("0. Exit");
            Console.Write("Please choose an option: ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out choice))
            {
                    invalidChoice = true;
                    Console.WriteLine("Invalid choice. Try again...");
                    continue;
            }

            invalidChoice = false;
                switch (choice)
                {
                    case 1:
                        Console.Write("Title: ");
                        var title = Console.ReadLine();
                        Console.Write("Price: ");
                        decimal price;
                        if (!decimal.TryParse(Console.ReadLine(), out price))
                            return;

                        var book = new Book();
                        book.Title = title;
                        book.Price = price;
                        book.PublishedYear = DateTime.Now;
                        book.AuthorID = 1;

                        Library.AddBook(book);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            }
             Library.PrintBooks();
        }
    }
}
