    using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Models
{
    class BankAccount
    {
        private string _accountnumber;
        private decimal _balance;
        public 

        public string AccountNumber { get; set; }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

    }
}
