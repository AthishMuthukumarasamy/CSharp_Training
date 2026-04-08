using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class BookShelf
    {
        private Book[] books = new Book[5];

        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public void Execute()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter details for Book {i + 1}:");

                Console.Write("Enter Book Name: ");
                string bookName = Console.ReadLine();

                Console.Write("Enter Author Name: ");
                string authorName = Console.ReadLine();

                this[i] = new Book(bookName, authorName);
                Console.WriteLine();
            }

            Console.WriteLine("Books in BookShelf:\n");

            for (int i = 0; i < 5; i++)
            {
                this[i].Display();
            }
        }
    }
}