using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_6
{
    internal class LineCount
    {
        public void Execute()
        {
            string filePath = @"C:\2026\C_Sharp\FileManagement.txt";
            string[] lines = File.ReadAllLines(filePath);
            int count = lines.Length;
            Console.WriteLine("\nNumber of lines in the file: " + count);
        }
    }
}
