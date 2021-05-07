using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_4
{
    public class Family
    {
        private List<Person> members = new List<Person>();

        public List<Person> Members
        {
            get { return members; }
            set { members = value; }
        }

        public void AddMember(Person person)
        {
            this.members.Add(person);
        }
        public Person GetOldestMember(List<Person> members)
        {
            Person firstMember = new Person("",-1);
            foreach (var member in this.members.OrderByDescending(a => a.Age))
            {
                firstMember = member;
                break;
            }
            return firstMember;
        }
    }
}
