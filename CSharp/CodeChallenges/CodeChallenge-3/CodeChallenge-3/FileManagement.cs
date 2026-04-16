using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_3
{
    internal class FileManagement
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\2026\\C_Sharp\\CodeChallenge-3\\Append.txt";

            Console.WriteLine("Enter text to append to the file:");
            string text = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(text);
            }

            Console.WriteLine("Text appended successfully.");
            Console.ReadLine();
        }

    }
}