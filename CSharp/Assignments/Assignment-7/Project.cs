using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Size : ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            int square = number * number;

            if (square > 20)
            {
                Console.WriteLine($"{number} - {square}");
            }
        }
    }
}