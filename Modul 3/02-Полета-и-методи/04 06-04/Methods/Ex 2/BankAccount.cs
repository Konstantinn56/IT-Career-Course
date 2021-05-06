using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2
{
    public class BankAccount
    {
        private int id;
        private double balance;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(int amount)
        {
            this.balance += amount;
        }
        public void Withdraw(int amount)
        {
            this.balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {this.id}, balance {this.balance}";
        }
    }
}
