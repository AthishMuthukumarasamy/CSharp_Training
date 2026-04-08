using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graduate program1 = new Graduate();
            program1.Execute();

            ProductProgram program2 = new ProductProgram();
            program2.Execute();

            ExceptionProgram program3 = new ExceptionProgram();
            program3.Execute();

            DelegateProgram program4 = new DelegateProgram();
            program4.Execute();
        }
    }
}
