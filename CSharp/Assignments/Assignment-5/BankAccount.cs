using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{ 
    internal class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    internal class BankAccount
    {
        private double balance;

        public void PerformTransaction()
        {
            try
            {
                Console.WriteLine("Enter initial balance:");
                balance = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter deposit amount:");
                double depositAmount = Convert.ToDouble(Console.ReadLine());
                Deposit(depositAmount);

                Console.WriteLine("Enter withdrawal amount:");
                double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                Withdraw(withdrawAmount);

                Console.WriteLine("Current Balance: " + balance);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Input Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
        }

        private void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be greater than zero");

            balance += amount;
        }

        private void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be greater than zero");

            if (amount > balance)
                throw new InsufficientBalanceException(
                    "Insufficient balance. Available balance: " + balance);

            balance -= amount;
        }
    }
}