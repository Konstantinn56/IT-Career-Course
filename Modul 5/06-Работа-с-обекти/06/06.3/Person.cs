using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._3
{
    public class Person
    {
        public int age;
        public string address;

        public int Age { get; set; }

        public void IntoruceYourselfIvan()
        {
            Console.WriteLine($"I am ivan, and i am {this.Age} years old!");
        }
        private int GetAge()
        {
            return this.Age;
        }
    }
}
