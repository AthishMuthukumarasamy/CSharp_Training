using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Interfaces;
using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.Factories
{
    class GraphFactory : OutputFactory
    {
        public override IOutput CreateOutput()
        {
            return new GraphOutput();
        }
    }
}