using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenge_4.BL;
using CodeChallenge_4.Concrete;

namespace CodeChallenge_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter distance 1: ");
            int km1 = int.Parse(Console.ReadLine());

            Console.Write("Enter distance 2: ");
            int km2 = int.Parse(Console.ReadLine());

            DistanceClass d1 = new DistanceClass(km1);
            DistanceClass d2 = new DistanceClass(km2);

            DistanceClass d3 = DistanceBL.Add(d1, d2);

            d3.Display();

            Console.ReadLine();
        }
    }
}