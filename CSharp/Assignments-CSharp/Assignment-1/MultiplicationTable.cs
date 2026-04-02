using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class MultiplicationTable
    {
        public static void PrintTable()
        {
            Console.WriteLine("Test Data : ");
            Console.WriteLine("Input the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Expected Output : ");


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
    }
}
