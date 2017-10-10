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
            Console.ReadKey();

        }
    }
}
