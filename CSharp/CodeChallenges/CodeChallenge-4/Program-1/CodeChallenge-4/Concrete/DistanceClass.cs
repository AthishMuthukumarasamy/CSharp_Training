using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenge_4.Abstracts;

namespace CodeChallenge_4.Concrete
{
    class DistanceClass : IDistance
    {
        public int Kilometer { get; set; }

        public DistanceClass(int km)
        {
            Kilometer = km;
        }

        public void Display()
        {
            Console.WriteLine("Total Distance: " + Kilometer + " km");
        }
    }
}