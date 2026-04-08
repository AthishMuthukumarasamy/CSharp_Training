using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_2
{
    class DelegateProgram
    {
        delegate int CalculatorDelegate(int a, int b);

        public void Execute()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            CalculatorDelegate add = Add;
            CalculatorDelegate subtract = Subtract;
            CalculatorDelegate multiply = Multiply;

            Console.WriteLine("\nAddition Result: " + Calculate(add, num1, num2));
            Console.WriteLine("Subtraction Result: " + Calculate(subtract, num1, num2));
            Console.WriteLine("Multiplication Result: " + Calculate(multiply, num1, num2));
        }

        int Calculate(CalculatorDelegate operation, int a, int b)
        {
            return operation(a, b);
        }

        int Add(int a, int b)
        {
            return a + b;
        }

        int Subtract(int a, int b)
        {
            return a - b;
        }

        int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}