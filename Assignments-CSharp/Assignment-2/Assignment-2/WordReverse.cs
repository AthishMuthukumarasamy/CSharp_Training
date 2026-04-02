using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class WordReverse
    {
        public static void DisplayReverseWord()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            char[] chars = word.ToCharArray();
            Array.Reverse(chars);

            string reversedWord = new string(chars);

            Console.WriteLine("Reversed word: " + reversedWord);
        }
    }
}