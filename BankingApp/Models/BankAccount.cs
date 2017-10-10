using System;
using System.Collections;
using System.Collections.Generic;

namespace BankingApp.Models
{
    internal class BankAccount
    {
        #region Fields

        //private readonly string _accountnumber;
        //   private decimal _balance;
        //   public const decimal WithdrawCost = 0.25M;
        private IList<Transaction> _transactions;
        #endregion

        #region Properties

        public string AccountNumber { get; set; }

        /*public decimal Balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }*/
        public decimal Balance { get; private set; }
        public int NumberOfTransactions { get { return _transactions.Count; } }

        #endregion

        #region Constructors


        public BankAccount(string acount) : this(acount, 0)
        {
            
        }

        public BankAccount(string accountnumber, decimal amount)
        {
            AccountNumber = accountnumber;
            Balance = amount;
            _transactions = new List<Transaction>();
        }

        #endregion
  
        #region Methods

        public virtual void Withdraw(decimal amount)
        {
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
            Balance += amount;
        }

        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till)
        {
            IList<Transaction> transList = new List<Transaction>();

            foreach (Transaction transaction in _transactions)
            {
                if(transaction.DateOfTrans >= from && transaction.DateOfTrans <= till)
                    transList.Add(transaction);
            }

            return transList;

        }


        #endregion
    }
}