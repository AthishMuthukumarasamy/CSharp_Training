using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmpCity { get; set; }
    public decimal EmpSalary { get; set; }
}

class EmployeeProgram
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        Console.Write("Enter number of employees: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Employee emp = new Employee();

            Console.WriteLine($"\nEnter details for Employee {i + 1}");

            Console.Write("Enter Employee Id: ");
            emp.EmpId = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            emp.EmpName = Console.ReadLine();

            Console.Write("Enter Employee City: ");
            emp.EmpCity = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            emp.EmpSalary = decimal.Parse(Console.ReadLine());

            employees.Add(emp);
        }

        Console.WriteLine("\n All Employees Data");
        DisplayEmployees(employees);

        Console.WriteLine("\n Employees with Salary > 45000");
        DisplayEmployees(employees.Where(e => e.EmpSalary > 45000).ToList());

        Console.WriteLine("\n Employees from Bangalore");
        DisplayEmployees(employees.Where(e => e.EmpCity.Equals("Bangalore")).ToList());

        Console.WriteLine("\n Employees Sorted by Name (Ascending)");
        DisplayEmployees(employees.OrderBy(e => e.EmpName).ToList());
    }

    static void DisplayEmployees(List<Employee> employees)
    {
        foreach (var emp in employees)
        {
            Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
        }
    }
}
