using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("\n========== Assignment - 2 ==========");
                Console.WriteLine("1. Pattern Printing");
                Console.WriteLine("2. Day Number to Day Name");
                Console.WriteLine("3. Average, Minimum & Maximum of Array");
                Console.WriteLine("4. Marks Operations");
                Console.WriteLine("5. Copy Array");
                Console.WriteLine("6. Word Length");
                Console.WriteLine("7. Reverse a Word");
                Console.WriteLine("8. Compare Two Words");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                // ✅ No Convert.ToInt32
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    choice = -1;
                    continue;
                }

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Pattern.DisplayPattern();
                        break;

                    case 2:
                        DayNo_DayName.DisplayDayName();
                        break;

                    case 3:
                        ArrayOperations.DisplayArrayResults();
                        break;

                    case 4:
                        MarksOperations.ProcessMarks();
                        break;

                    case 5:
                        ArrayCopy.CopyArray();
                        break;

                    case 6:
                        WordLength.DisplayWordLength();
                        break;

                    case 7:
                        WordReverse.DisplayReverseWord();
                        break;

                    case 8:
                        WordCompare.CompareWords();
                        break;

                    case 0:
                        Console.WriteLine("Exiting Assignment - 2...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();   // optional but improves usability
                }
            }
        }
    }
}