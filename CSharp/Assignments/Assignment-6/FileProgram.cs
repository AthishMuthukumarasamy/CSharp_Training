using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_6
{
    internal class FileProgram
    {
        public void Execute()
        {
            string filePath = @"C:\2026\C_Sharp\FileManagement.txt";

            string[] messages = new string[5];

            Console.WriteLine("Enter 5 strings to write into the file:\n");
            for (int i = 0; i < messages.Length; i++)
            {
                Console.Write($"Enter string {i + 1}: ");
                messages[i] = Console.ReadLine();
            }

            File.WriteAllLines(filePath, messages);
            Console.WriteLine("\nData written to file successfully.\n");

            string[] fileData = File.ReadAllLines(filePath);

            Console.WriteLine("Data read from file:");
            foreach (string line in fileData)
            {
                Console.WriteLine(line);
            }
        }
    }
}