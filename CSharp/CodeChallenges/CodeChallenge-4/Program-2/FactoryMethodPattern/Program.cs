using System;
using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter output type: Graph / Table / Text");
            string choice = Console.ReadLine().ToLower();

            OutputFactory factory = null;

            if (choice == "graph")
            {
                factory = new GraphFactory();
            }
            else if (choice == "table")
            {
                factory = new TableFactory();
            }
            else if (choice == "text")
            {
                factory = new TextFactory();
            }
            else
            {
                Console.WriteLine("Invalid choice");
                Console.ReadLine();
                return;
            }

            IOutput output = factory.CreateOutput();
            output.Generate();

            Console.ReadLine();
        }
    }
}