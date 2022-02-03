using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class BankAccount
    {
        public BankAccount(double bal)
        {
            this.Balance = bal;
        }
        public double Balance { get; set; }
        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
    }

}
