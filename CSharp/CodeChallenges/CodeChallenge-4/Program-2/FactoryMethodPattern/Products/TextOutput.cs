using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Products
{
    class TextOutput : IOutput
    {
        public void Generate()
        {
            Console.WriteLine("Text summary report generated.");
        }
    }

}
