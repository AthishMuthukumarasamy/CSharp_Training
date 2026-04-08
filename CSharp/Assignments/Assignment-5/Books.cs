using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine("Book Name   : " + BookName);
            Console.WriteLine("Author Name: " + AuthorName);
        }
    }
}
