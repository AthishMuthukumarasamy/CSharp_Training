using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class ArrayCopy
    {
        public static void CopyArray()
        {
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] source = new int[n];
            int[] destination = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                source[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                destination[i] = source[i];
            }

            Console.WriteLine("\nElements in second array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(destination[i] + " ");
            }
        }
    }
}