using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Assignment 3 =====");
            Console.WriteLine("1. Bank Program");
            Console.WriteLine("2. Student Result Program");
            Console.WriteLine("3. Sale Details Program");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RunBankProgram();
                    break;

                case 2:
                    RunStudentProgram();
                    break;

                case 3:
                    RunSaleProgram();
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.ReadLine();
        }

        static void RunBankProgram()
        {
            Console.Write("Enter Account Number: ");
            int accNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Account Type: ");
            string accType = Console.ReadLine();

            BankAccount acc = new BankAccount(accNo, name, accType);

            Console.Write("Enter Transaction Type (D/W): ");
            char tType = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Amount: ");
            double amount = double.Parse(Console.ReadLine());

            acc.DoTransaction(tType, amount);
            acc.ShowData();
        }

        static void RunStudentProgram()
        {
            Console.Write("Enter Roll No: ");
            int rollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Class: ");
            string className = Console.ReadLine();

            Console.Write("Enter Semester: ");
            int sem = int.Parse(Console.ReadLine());

            Console.Write("Enter Branch: ");
            string branch = Console.ReadLine();

            ResultStudent student =
                new ResultStudent(rollNo, name, className, sem, branch);

            student.GetMarks();
            student.DisplayData();
            student.DisplayResult();
        }

        static void RunSaleProgram()
        {
            Console.Write("Enter Sales No: ");
            int sNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Product No: ");
            int pNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int qty = int.Parse(Console.ReadLine());

            Console.Write("Enter Date of Sale (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            SaleDetails sale = new SaleDetails(sNo, pNo, price, qty, date);
            sale.Sales();
            sale.ShowData();
        }
    }
}