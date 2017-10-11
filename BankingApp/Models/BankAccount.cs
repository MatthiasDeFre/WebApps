using System;
using System.Collections.Generic;

namespace BankingApp.Models
{
    public class BankAccount : IBankAccount
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

            if (from == null && !till.HasValue)
            {
                return _transactions;
            }
            if (from == null)
                from = DateTime.MinValue;
            if (till == null)
                till = DateTime.MaxValue;
            foreach (Transaction transaction in _transactions)
            {
                 
                if(transaction.DateOfTrans.Date >= from.Value.Date && transaction.DateOfTrans.Date <= till.Value.Date)
                    transList.Add(transaction);
            }

            return transList;

        }

        public override bool Equals(object obj)
        {
            BankAccount bankAcc = obj as BankAccount;
            if (bankAcc == null)
                return false;
            return AccountNumber == bankAcc.AccountNumber;
        }

        #endregion
    }
}