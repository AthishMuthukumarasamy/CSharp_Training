using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Products
{
    class TableOutput : IOutput
    {
        public void Generate()
        {
            Console.WriteLine("Table report generated.");
        }
    }

}
