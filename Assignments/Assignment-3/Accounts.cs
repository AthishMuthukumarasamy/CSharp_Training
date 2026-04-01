using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Accounts
    {
        protected int AccountNo;
        protected string CustomerName;
        protected string AccountType;
        protected char TransactionType; 
        protected double Amount;
        protected double Balance;

        public Accounts(int accNo, string custName, string accType)
        {
            AccountNo = accNo;
            CustomerName = custName;
            AccountType = accType;
            Balance = 0;
        }

        // Deposit
        protected void Credit(double amount)
        {
            Console.WriteLine("\nBalance before deposit : " + Balance);
            Balance += amount;
            Console.WriteLine("Deposited Amount      : " + amount);
            Console.WriteLine("Balance after deposit  : " + Balance);
        }

        // Withdraw
        protected void Debit(double amount)
        {
            Console.WriteLine("\nBalance before withdrawal : " + Balance);

            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawn Amount        : " + amount);
                Console.WriteLine("Balance after withdrawal: " + Balance);
            }
            else
            {
                Console.WriteLine("Withdrawal failed – Insufficient balance");
                Console.WriteLine("Current Balance        : " + Balance);
            }
        }

        protected void UpdateBalance()
        {
            if (TransactionType == 'D' || TransactionType == 'd')
                Credit(Amount);
            else if (TransactionType == 'W' || TransactionType == 'w')
                Debit(Amount);
            else
                Console.WriteLine("Invalid transaction type");
        }

        public virtual void ShowData()
        {
            Console.WriteLine("\n--- Account Summary ---");
            Console.WriteLine("Account No   : " + AccountNo);
            Console.WriteLine("Customer     : " + CustomerName);
            Console.WriteLine("Account Type : " + AccountType);
            Console.WriteLine("Final Balance: " + Balance);
        }
    }
}