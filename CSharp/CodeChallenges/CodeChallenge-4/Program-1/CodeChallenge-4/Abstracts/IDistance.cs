using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_4.Abstracts
{
    interface IDistance
    {
        int Kilometer { get; set; }
        void Display();
    }
}