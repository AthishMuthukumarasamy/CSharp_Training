using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ArthematicOperations
    {
        public static void Calculate()
        {
            Console.WriteLine("Test Data ");
            Console.WriteLine("Input First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Operation : ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Expected Output : ");

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1+num2}");
                    break;

                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1-num2}");
                    break;

                case '*':
                    Console.WriteLine($"{num1} x {num2} = {num1*num2}");
                    break;

                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"{num1} / {num2} = {(double)num1 / num2}");
                    else
                        Console.WriteLine("Denominator cannot be zero !");
                    break;

                case '%':
                    if (num2 != 0)
                        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    else
                        Console.WriteLine("Denominator cannot be zero !");
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    break;

            }

        }
    }
}
