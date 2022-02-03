using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public class Employee : Person
    {
        public string Company { get; private set; }

        public Employee(string name, string company) : base(name)
        {
            this.Company = company;
        }

        public void Work()
        {
            Console.WriteLine("Working...");
        }
    }
}
