using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_2
{
    class ExceptionProgram
    {
        public void Execute()
        {
            try
            {
                Console.Write("Enter an integer: ");
                int number = Convert.ToInt32(Console.ReadLine());

                CheckNumber(number);

                Console.WriteLine("Number is valid ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
        }

        void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new Exception("Number cannot be negative.");
            }
        }
    }
}
