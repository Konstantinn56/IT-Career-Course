using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_3
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        public double GetBalance(List<BankAccount> accounts)
        {
            double balance = 0;
            foreach (var acc in accounts)
            {
                balance += acc.Balance;
            }
            return balance;
        }
    }
}
