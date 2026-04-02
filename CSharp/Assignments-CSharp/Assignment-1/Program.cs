using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {

        static void Main()
        {

            Console.WriteLine("====== Assignment 1 ======");
            Console.WriteLine("1. Check Positive or Negative");
            Console.WriteLine("2. Check Two Numbers Are Equal or Not");
            Console.WriteLine("3. Arithmetic Operations (+, -, *, /, %)");
            Console.WriteLine("4. Multiplication Table");
            Console.WriteLine("5. Sum of Two Numbers (Triple if Same)");
            Console.WriteLine();
            Console.WriteLine("Enter your choice (1-5):");


            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PositiveNegative.CheckPositiveOrNegative();
                    break;

                case 2:
                    CheckEqual.CheckNumbers();
                    break;

                case 3:
                    ArthematicOperations.Calculate();
                    break;

                case 4:
                    MultiplicationTable.PrintTable();
                    break;

                case 5:
                    SumOfTwoNumbers.Sum();
                    break;


                default:
                    Console.WriteLine("Invalid choice. Please choose between 1 and 5.");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Thank You !");
        }

    }
}
