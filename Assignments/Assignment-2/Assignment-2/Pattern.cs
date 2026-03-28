using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Pattern
    {
        public static void DisplayPattern()
        {
            Console.Write("Enter a digit: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                // With spaces
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();

                // Without spaces
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}", num);
                }
                Console.WriteLine();
            }
        }
    }
}