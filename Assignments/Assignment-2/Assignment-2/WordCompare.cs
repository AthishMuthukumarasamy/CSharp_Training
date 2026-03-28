using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class WordCompare
    {
        public static void CompareWords()
        {
            Console.Write("Enter first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter second word: ");
            string word2 = Console.ReadLine();

            if (word1.Equals(word2))
            {
                Console.WriteLine("Both words are the same.");
            }
            else
            {
                Console.WriteLine("Both words are different.");
            }
        }
    }
}