using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_3
{
    internal class Cricket
    {
        public void Pointscalculation(int no_of_matches)
        {
            int sum = 0;

            Console.WriteLine("Enter the points scored in each match:");

            for (int i = 1; i <= no_of_matches; i++)
            {
                Console.Write($"Match {i}: ");
                int score = Convert.ToInt32(Console.ReadLine());
                sum += score;
            }

            double average = (double)sum / no_of_matches;

            Console.WriteLine("\n Team Status ");
            Console.WriteLine("Number of Matches : " + no_of_matches);
            Console.WriteLine("Total Points      : " + sum);
            Console.WriteLine("Average Points    : " + average);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of matches played: ");
            int matches = Convert.ToInt32(Console.ReadLine());

            Cricket team = new Cricket();
            team.Pointscalculation(matches);
        }
    }
}