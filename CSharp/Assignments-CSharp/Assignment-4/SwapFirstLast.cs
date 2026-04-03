using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class SwapFirstLast
    {
        public void Execute()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string result = SwapCharacters(str);
            Console.WriteLine(result);
        }

        private string SwapCharacters(string str)
        {
            if (str.Length <= 1)
                return str;

            char first = str[0];
            char last = str[str.Length - 1];

            string middle = str.Substring(1, str.Length - 2);

            return last + middle + first;
        }
    }
}
