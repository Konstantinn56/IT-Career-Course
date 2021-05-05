using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_2
{
    class Family
    {
        public List<Person> people = new List<Person>();

        public void PrintPeople()
        {
            var sorted = people.OrderBy(p => p.name);
            foreach (var p in sorted)
            {
                Console.WriteLine($"{p.name} {p.age}");
            }
        }
        
    }
}
