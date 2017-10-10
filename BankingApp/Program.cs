using BankingApp.Models;
using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BankAccount app = new BankAccount("test");
            Console.WriteLine($"Banknumber{app.AccountNumber}");
            app.Deposit(30);
            Console.WriteLine($"Number trans {app.NumberOfTransactions} and balance is {app.Balance}");
            app.Withdraw(30);
            Console.WriteLine($"Number trans {app.NumberOfTransactions} and balance is {app.Balance}");
            app.Deposit(30);
            Console.WriteLine($"Number trans {app.NumberOfTransactions} and balance is {app.Balance}");
        


            SavingsAccounts savApp = new SavingsAccounts("test", 0.01M);
            savApp.Deposit(30);
            savApp.Deposit(30);
            Console.WriteLine($"Number trans {savApp.NumberOfTransactions} and balance is {savApp.Balance}");
            savApp.AddInterest();
            Console.WriteLine($"Number trans {savApp.NumberOfTransactions} and balance is {savApp.Balance}");
            savApp.Withdraw(30);
            Console.WriteLine($"Number trans {savApp.NumberOfTransactions} and balance is {savApp.Balance}");
            Console.ReadKey();
        }
    }
}
