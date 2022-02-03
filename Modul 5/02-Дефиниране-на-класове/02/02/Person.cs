using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccounts> accounts;

        ////////////////////////////////////////////////////////////////////////////////////////////

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = new List<BankAccounts>();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        public List<BankAccounts> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////

        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is {this.Name}, and im {this.Age} years old");
        }

        public void AddAccount(BankAccounts account)
        {
            this.Accounts.Add(account);
        }

        public double GetBalance()
        {
            return this.Accounts.Sum(a => a.Balance);
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
