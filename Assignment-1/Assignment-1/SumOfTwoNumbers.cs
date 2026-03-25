using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class SumOfTwoNumbers
    {
        public static void Sum()
        {

            Console.WriteLine("Input first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int triplet = 3 * sum;

            if (num1 == num2)
            {
                Console.WriteLine($"Since {num1} and {num2} are same, Triplet of the Sum is : {triplet}");
            }
            else
            {
                Console.WriteLine($"Sum : {sum}");
            }

        }
    }
}
