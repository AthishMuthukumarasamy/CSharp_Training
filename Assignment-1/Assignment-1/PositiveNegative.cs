using System;

namespace Assignment_1
{
    internal class PositiveNegative
    {
        public static void CheckPositiveOrNegative()
        {
            Console.WriteLine("Test Data : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"{num} is a positive number");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is a negative number");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}