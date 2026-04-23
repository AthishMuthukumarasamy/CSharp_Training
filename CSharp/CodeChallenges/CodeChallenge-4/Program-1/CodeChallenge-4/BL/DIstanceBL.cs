using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenge_4.Concrete;

namespace CodeChallenge_4.BL
{
    class DistanceBL
    {
        public static DistanceClass Add(DistanceClass d1, DistanceClass d2)
        {
            int sum = d1.Kilometer + d2.Kilometer;
            return new DistanceClass(sum);
        }
    }
}