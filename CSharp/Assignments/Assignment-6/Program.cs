using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookShelf program1 = new BookShelf();
            program1.Execute();

            FileProgram program2 = new FileProgram();
            program2.Execute();

            LineCount program3 = new LineCount();
            program3.Execute();
        }
    }
}
