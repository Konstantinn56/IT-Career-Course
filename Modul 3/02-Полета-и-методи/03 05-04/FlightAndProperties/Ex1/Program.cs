using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            acc.Id = 1;
            acc.Balance = 1.5;

            Console.WriteLine($"Account {acc.Id}, balance {acc.Balance}");
        }
    }
}
