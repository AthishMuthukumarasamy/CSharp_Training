using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount program1 = new BankAccount();
            program1.PerformTransaction();

            Console.WriteLine();

            Scholarship program2 = new Scholarship();
            program2.Merit();

            Console.WriteLine();

            BookShelf program3 = new BookShelf();
            program3.StoreAndDisplayBooks();
        }
    }
}
