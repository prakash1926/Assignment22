using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nLibrary Management System Menu:");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book ID: ");
                        int bookId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Book Author: ");
                        string author = Console.ReadLine();

                        Console.Write("Enter Book Genre: ");
                        string genre = Console.ReadLine();

                        Book newBook = new Book
                        {
                            BookId = bookId,
                            Title = title,
                            Author = author,
                            Genre = genre,
                            IsAvailable = true
                        };

                        library.AddBook(newBook);
                        break;

                    case 2:
                        library.ViewAllBooks();
                        break;

                    case 3:
                        Console.Write("Enter Book ID to search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        library.SearchBookById(searchId);
                        break;

                    case 4:
                        Console.Write("Enter Book Title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchBookByTitle(searchTitle);
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
        }
    }
}
