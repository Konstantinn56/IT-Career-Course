﻿using System;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            acc.Id = 1;
            acc.Deposit(15);
            acc.Withdraw(5);

            Console.WriteLine(acc.ToString());
        }
    }
}
