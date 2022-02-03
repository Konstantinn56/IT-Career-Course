using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public class Person
    {
        public string Name { get; set; }
        public string Adress { get; set; }

        public Person(string Name)
        {
            this.Name = Name;
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }
}
