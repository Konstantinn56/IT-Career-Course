using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Family
    {
        private List<Person> members = new List<Person>();

        public void AddMember(Person person)
        {
            this.members.Add(person);
        }
        
        public void Print()
        {
            foreach (var m in members.OrderBy(n => n.Name).ThenBy(a => a.Age))
            {
                Console.WriteLine(m);
            }
        }

    }
}
