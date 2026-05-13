using System;
using System.Data;
using System.Data.SqlClient;

namespace CodeChallenge_7
{
    // Business Layer
    class Employee
    {
        public string EmpName { get; set; }
        public decimal EmpSal { get; set; }
        public char EmpType { get; set; }

        DataAccess access = new DataAccess();

        // Insert Employee
        public int AddEmployee()
        {
            Console.WriteLine("Enter Employee Name :");
            EmpName = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary :");
            EmpSal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Employee Type (F/P) :");
            EmpType = Convert.ToChar(Console.ReadLine().ToUpper()); 

            return access.InsertEmployee(EmpName, EmpSal, EmpType);
        }

        // Display Employees
        public SqlDataReader ShowEmployees()
        {
            return access.GetEmployees();
        }
    }

    // Data Access Layer
    class DataAccess
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        // Connection
        public SqlConnection GetConnection()
        {
            string str = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeeManagement;Integrated Security=True";

            con = new SqlConnection(str);
            con.Open();
            return con;
        }

        // Call Stored Procedure
        public int InsertEmployee(string name, decimal sal, char type)
        {
            int result = 0;

            try
            {
                con = GetConnection();

                cmd = new SqlCommand("add_employee", con); 
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@empname", name);
                cmd.Parameters.AddWithValue("@empsal", sal);
                cmd.Parameters.AddWithValue("@emptype", type);

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        // Get All Employees
        public SqlDataReader GetEmployees()
        {
            try
            {
                con = GetConnection();

                cmd = new SqlCommand("select * from employee_details", con);
                dr = cmd.ExecuteReader();

                return dr;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine("------ Insert Employee ------");

            int res = emp.AddEmployee();

            if (res > 0)   
                Console.WriteLine("Employee Inserted Successfully");
            else
                Console.WriteLine("Insertion Failed");

            Console.WriteLine("\n------ Employee Details ------");

            SqlDataReader dr = emp.ShowEmployees();

            while (dr.Read())
            {
                Console.WriteLine(
                    dr["empno"] + " " +
                    dr["empname"] + " " +
                    dr["empsal"] + " " +
                    dr["emptype"]);
            }

            Console.ReadLine();
        }
    }
}