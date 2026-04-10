using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordsFilter
{
    static void Main()
    {
        Console.Write("Enter number of words: ");
        int count = int.Parse(Console.ReadLine());

        string[] words = new string[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter word: ");
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("\nOutput:");
        for (int i = 0; i < count; i++)
        {
            if (words[i].StartsWith("a") && words[i].EndsWith("m"))
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}