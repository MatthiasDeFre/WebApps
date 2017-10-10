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

        }
    }
}
