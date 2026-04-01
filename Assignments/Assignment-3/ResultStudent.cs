using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    //Child class
    internal class ResultStudent : Student
    {
        int[] marks = new int[5];

        public ResultStudent(int r, string n, string c, int s, string b)
            : base(r, n, c, s, b)
        {
        }

        public void GetMarks()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter marks for subject " + (i + 1) + ": ");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            int total = 0;
            bool fail = false;

            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                    fail = true;
                total += marks[i];
            }

            double avg = total / 5.0;

            Console.WriteLine("\nAverage: " + avg);

            if (fail || avg < 50)
                Console.WriteLine("Result: FAILED");
            else
                Console.WriteLine("Result: PASSED");
        }

        public override void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine("\nMarks:");
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
        }
    }
}
