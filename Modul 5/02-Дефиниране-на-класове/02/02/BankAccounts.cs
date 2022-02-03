using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class BankAccounts
    {
        private int id;
        private double balance;

        ////////////////////////////////////////////////////////////////////////////////////////////

        public BankAccounts(int id , double balance)
        {
            this.ID = id;
            this.Balance = balance;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////

        public int ID
        {
            get { return id; }
            private set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("The Amount must be positive!");
                }
                balance = value; 
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////
        
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("The Deposit must me greater than 0 !");
            }
            this.Balance += amount;  
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0 || amount > this.Balance)
            {
                throw new InvalidOperationException("Invalid Amount!");
            }
            this.Balance -= amount;
        }
    }
}
