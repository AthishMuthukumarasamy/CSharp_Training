using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CodeChallenge_7
{
    class EmployeeUpdate   
    {
        public int Empno { get; set; }

        DataAccessUpdate access = new DataAccessUpdate(); 

        public void UpdateSalary()
        {
            Console.WriteLine("Enter Employee ID :");
            Empno = Convert.ToInt32(Console.ReadLine());

            decimal updatedSalary =
                access.UpdateEmployeeSalary(Empno);

            if (updatedSalary > 0)
            {
                Console.WriteLine("Updated Salary : " + updatedSalary);
            }
            else
            {
                Console.WriteLine("Employee ID Not Found");
            }
        }

        public SqlDataReader DisplayRecords()
        {
            return access.GetEmployees();
        }
    }

    class DataAccessUpdate   
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public SqlConnection GetConnection()
        {
            string str = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeeManagement;Integrated Security=True";

            con = new SqlConnection(str);
            con.Open();
            return con;
        }

        public decimal UpdateEmployeeSalary(int empid)
        {
            decimal salary = 0;

            try
            {
                con = GetConnection();

                cmd = new SqlCommand("update_salary", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@empid", empid);

                SqlParameter outputParam = new SqlParameter();
                outputParam.ParameterName = "@updated_salary";
                outputParam.SqlDbType = SqlDbType.Decimal;
                outputParam.Precision = 10;
                outputParam.Scale = 2;
                outputParam.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(outputParam);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["@updated_salary"].Value != DBNull.Value)
                {
                    salary = Convert.ToDecimal(
                        cmd.Parameters["@updated_salary"].Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return salary;
        }

        public SqlDataReader GetEmployees()
        {
            con = GetConnection();

            cmd = new SqlCommand("select * from employee_details", con);

            dr = cmd.ExecuteReader();

            return dr;
        }
    }

    class Program_Update   
    {
        static void Main(string[] args)
        {
            EmployeeUpdate emp = new EmployeeUpdate();

            Console.WriteLine("------ Update Salary ------");

            emp.UpdateSalary();

            Console.WriteLine("\n------ Employee Records ------");

            SqlDataReader dr = emp.DisplayRecords();

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