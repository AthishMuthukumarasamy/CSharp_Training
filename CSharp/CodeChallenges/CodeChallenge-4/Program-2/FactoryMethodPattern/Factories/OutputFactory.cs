using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Factories
{
    abstract class OutputFactory
    {
        public abstract IOutput CreateOutput();
    }
}