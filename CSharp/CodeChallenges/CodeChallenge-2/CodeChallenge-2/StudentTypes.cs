using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_2
{
    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }

        public override void Execute()
        {
            Console.WriteLine("Enter Undergraduate Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Student ID:");
            StudentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Grade:");
            Grade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nUndergraduate Student");
            Console.WriteLine("Passed: " + IsPassed(Grade));
        }
    }

    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }

        public override void Execute()
        {
            Console.WriteLine("Enter Graduate Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Student ID:");
            StudentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Grade:");
            Grade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nGraduate Student");
            Console.WriteLine("Passed: " + IsPassed(Grade));
        }
    }
}
