using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoveCharacter program1 = new RemoveCharacter();
            program1.Execute();

            SwapFirstLast program2 = new SwapFirstLast();      
            program2.Execute();

            SortStackDescending program3 = new SortStackDescending();   
            program3.Execute();
        }
    }
}
