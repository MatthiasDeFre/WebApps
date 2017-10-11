using System;
using System.Collections.Generic;

namespace BankingApp.Models
{
    public interface IBankAccount
    {
        string AccountNumber { get; set; }
        decimal Balance { get; }
        int NumberOfTransactions { get; }
        void Withdraw(decimal amount);
        void Deposit(decimal amount);
        IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till);
    }
}