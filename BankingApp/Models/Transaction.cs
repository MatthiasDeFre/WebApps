using System;

namespace BankingApp.Models
{
    public class Transaction
    {
        #region Properties
        public decimal Amount { get; set; }
        public DateTime DateOfTrans { get; private set; }
        public TransactionType TransType { get; set; }
        public bool IsDeposit
        {
            get { return TransType == TransactionType.Deposit; }
        }

        public bool IsWithdraw
        {
            get { return TransType == TransactionType.Withdraw; }
        }
        #endregion

        #region Constructors
        public Transaction(decimal amount, TransactionType transType)
        {
            Amount = amount;
            TransType = transType;
            DateOfTrans = DateTime.Today;
        }

        #endregion
        #region Methods
       
        #endregion





    }
}
