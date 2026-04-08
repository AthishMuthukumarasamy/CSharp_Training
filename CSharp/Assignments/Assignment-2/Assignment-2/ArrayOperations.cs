using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class ArrayOperations
    {
        public static void DisplayArrayResults()
        {

            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];
            }

            double average = (double)sum / arr.Length;

            Console.WriteLine("Average value of array elements: " + average);
            Console.WriteLine("Minimum value in array: " + min);
            Console.WriteLine("Maximum value in array: " + max);
        }
    }
}