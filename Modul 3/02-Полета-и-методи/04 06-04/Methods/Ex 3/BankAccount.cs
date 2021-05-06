using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_3
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
    }
}
