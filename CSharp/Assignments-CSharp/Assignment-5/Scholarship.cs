using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class NoScholarshipException : ApplicationException
    {
        public NoScholarshipException(string message) : base(message)
        {
        }
    }

    internal class Scholarship
    {
        public void Merit()
        {
            try
            {
                Console.WriteLine("Enter marks:");
                double marks = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter total fees:");
                double fees = Convert.ToDouble(Console.ReadLine());

                double scholarshipAmount = CalculateScholarship(marks, fees);

                Console.WriteLine("Scholarship Amount: " + scholarshipAmount);
            }
            catch (NoScholarshipException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input: " + ex.Message);
            }
        }

        public double CalculateScholarship(double marks, double fees)
        {
            if (marks >= 70 && marks <= 80)
            {
                return fees * 0.20;
            }
            else if (marks > 80 && marks <= 90)
            {
                return fees * 0.30;
            }
            else if (marks > 90)
            {
                return fees * 0.50;
            }
            else
            {
                throw new NoScholarshipException("Student is not eligible for scholarship");
            }
        }
    }
}