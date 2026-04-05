using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class BookShelf
    {
        public Books[] books = new Books[3];

        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public void StoreAndDisplayBooks()
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Enter Book {i + 1} Name:");
                string bookName = Console.ReadLine();

                Console.WriteLine($"Enter Author {i + 1} Name:");
                string authorName = Console.ReadLine();

                this[i] = new Books(bookName, authorName);
            }

            Console.WriteLine("\n---- Book Details ----");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"\nBook {i + 1}");
                this[i].Display();
            }
        }
    }
}
