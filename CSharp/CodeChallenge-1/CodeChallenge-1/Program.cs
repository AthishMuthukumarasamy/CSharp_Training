using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager program1 = new EmployeeManager();
            program1.Run();

            Console.WriteLine();

            NestedStructure program2 = new NestedStructure();
            program2.Run();
        }
    }
}
