using System;
using System.Collections.Generic;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "asd";
            person1.Age = 12;

            List<BankAccount> accounts = new List<BankAccount>();

            BankAccount acc = new BankAccount();
            acc.Id = 1;
            acc.Balance = 1234.5152;
            BankAccount acc2 = new BankAccount();
            acc2.Id = 2;
            acc2.Balance = 12123;
            BankAccount acc3 = new BankAccount();
            acc3.Id = 3;
            acc3.Balance = 1212323;

            accounts.Add(acc);
            accounts.Add(acc2);
            accounts.Add(acc3);

            double balance = person1.GetBalance(accounts);

            Console.WriteLine(balance);
        }
    }
}
