using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_1
{
    internal class NestedStructure
    {
        struct Employee
        {
            public string name;

            public struct DateOfBirth
            {
                public int day;
                public int month;
                public int year;
            }

            public DateOfBirth dob;
        }

        public void Run()
        {
            Employee[] employees = new Employee[2];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter details for employee {i + 1}:");

                Console.Write("Name of the employee: ");
                employees[i].name = Console.ReadLine();

                Console.Write("Input day of the birth: ");
                employees[i].dob.day = int.Parse(Console.ReadLine());

                Console.Write("Input month of the birth: ");
                employees[i].dob.month = int.Parse(Console.ReadLine());

                Console.Write("Input year of the birth: ");
                employees[i].dob.year = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("\n--- Employee Details ---");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Name: {employees[i].name}");
                Console.WriteLine($"DOB: {employees[i].dob.day}/{employees[i].dob.month}/{employees[i].dob.year}");
                Console.WriteLine();
            }
        }
    }
}