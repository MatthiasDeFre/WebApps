using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Models
{
    class SavingsAccounts : BankAccount
    {
        #region Fields

        protected const decimal WithdrawCost = 0.25M;


        #endregion

        #region Properties

        public decimal InterestRate { get; set; }

        #endregion

        #region Constructors

        public SavingsAccounts(string accountnumber, decimal interestRate) : base(accountnumber)
        {
            InterestRate = interestRate;
        }
        #endregion

        #region Methods

        public void AddInterest()
        {
            Deposit(Balance * InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            base.Withdraw(WithdrawCost);
        }

        #endregion
    }
}
