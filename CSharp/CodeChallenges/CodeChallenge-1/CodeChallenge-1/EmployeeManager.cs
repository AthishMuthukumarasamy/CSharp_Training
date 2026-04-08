using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_1
{
    internal class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        public void Run()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== Employee Management Menu =====");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. Search Employee by ID");
                Console.WriteLine("4. Update Employee Details");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Exit");
                Console.WriteLine("====================================");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ViewEmployees();
                        break;
                    case 3:
                        SearchEmployee();
                        break;
                    case 4:
                        UpdateEmployee();
                        break;
                    case 5:
                        DeleteEmployee();
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 6);
        }

        // ADD EMPLOYEE
        private void AddEmployee()
        {
            Employee emp = new Employee();

            Console.Write("Enter ID: ");
            emp.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Department: ");
            emp.Department = Console.ReadLine();

            Console.Write("Enter Salary: ");
            emp.Salary = double.Parse(Console.ReadLine());

            employees.Add(emp);
            Console.WriteLine("Employee added successfully!");
        }

        // VIEW ALL
        private void ViewEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(
                    "ID: " + employees[i].Id +
                    ", Name: " + employees[i].Name +
                    ", Department: " + employees[i].Department +
                    ", Salary: " + employees[i].Salary
                );
            }
        }

        // SEARCH
        private void SearchEmployee()
        {
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Employee found = null;

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == id)
                {
                    found = employees[i];
                    break;
                }
            }

            if (found != null)
            {
                Console.WriteLine("Employee Found:");
                Console.WriteLine("Name: " + found.Name);
                Console.WriteLine("Department: " + found.Department);
                Console.WriteLine("Salary: " + found.Salary);
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        // UPDATE
        private void UpdateEmployee()
        {
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Employee found = null;

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == id)
                {
                    found = employees[i];
                    break;
                }
            }

            if (found != null)
            {
                Console.Write("Enter New Name: ");
                found.Name = Console.ReadLine();

                Console.Write("Enter New Department: ");
                found.Department = Console.ReadLine();

                Console.Write("Enter New Salary: ");
                found.Salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Employee updated successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        // DELETE
        private void DeleteEmployee()
        {
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            int index = -1;

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                employees.RemoveAt(index);
                Console.WriteLine("Employee deleted successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}