using System;
using System.Collections.Generic;
using System.Reflection;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ivan", 12);
            Person person2 = new Person("Gosho", 13);
            
            BankAccounts account1 = new BankAccounts(1,666);
 
            account1.Withdraw(666);
            

        }
    }
}
