using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class MarksOperations
    {
        public static void ProcessMarks()
        {
            int[] marks = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter mark " + (i + 1) + ": ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            int min = marks[0];
            int max = marks[0];

            for (int i = 0; i < 10; i++)
            {
                total += marks[i];

                if (marks[i] < min)
                    min = marks[i];

                if (marks[i] > max)
                    max = marks[i];
            }

            double average = (double)total / 10;

            Console.WriteLine("\nTotal Marks: " + total);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine("Minimum Marks: " + min);
            Console.WriteLine("Maximum Marks: " + max);

            int[] asc = (int[])marks.Clone();
            Array.Sort(asc);
            Console.WriteLine("\nMarks in Ascending Order:");
            foreach (int m in asc)
            {
                Console.Write(m + " ");
            }

            Array.Reverse(asc);
            Console.WriteLine("\n\nMarks in Descending Order:");
            foreach (int m in asc)
            {
                Console.Write(m + " ");
            }
        }
    }
}
