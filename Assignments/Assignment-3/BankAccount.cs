using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class BankAccount : Accounts
    {
        public BankAccount(int accNo, string custName, string accType)
            : base(accNo, custName, accType)
        {
        }

        public void DoTransaction(char type, double amount)
        {
            TransactionType = type;
            Amount = amount;
            UpdateBalance();
        }
    }
}