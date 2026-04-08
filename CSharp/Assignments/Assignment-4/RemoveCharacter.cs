using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class RemoveCharacter
    {
        public void Execute()
        {
            Console.Write("Enter a string : ");
            string input = Console.ReadLine();

            Console.Write("Enter the position to remove : ");
            int position = int.Parse(Console.ReadLine());

            string result = RemoveChar(input, position);

            Console.WriteLine("Result: " + result);
        }

        private static string RemoveChar(string str, int position)
        {
            return str.Remove(position, 1);
        }
    }
}