using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Add_Two_INTEGERS
    {
        static void Equal(String[] args)
        {
            Console.WriteLine("Input 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 2nd number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal");
            }
        }
    }
}
