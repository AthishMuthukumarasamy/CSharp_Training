using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment_6
{
    internal class Book
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Book(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            System.Console.WriteLine(
                $"Book Name: {BookName}, Author Name: {AuthorName}"
            );
        }
    }
}