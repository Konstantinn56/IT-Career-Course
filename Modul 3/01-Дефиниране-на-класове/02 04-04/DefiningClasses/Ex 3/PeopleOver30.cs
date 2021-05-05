using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_3
{
    class PeopleOver30
    {
        public List<Person> peopleOver30 = new List<Person>();

        public void PrintPeopleOver30()
        {
            var sorted = peopleOver30.OrderBy(p => p.name);
            foreach (var p in sorted.Where(a => a.age > 30))
            {
                
                Console.WriteLine($"{p.name} - {p.age}");
            }
        }
    }
}
