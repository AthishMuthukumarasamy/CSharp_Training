using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class WordLength
    {
        public static void DisplayWordLength()
        {
            Console.Write("Enter a word : ");
            string word = Console.ReadLine();

            int length = word.Length;

            Console.WriteLine("Length of the word : " + length);
        }
    }
}