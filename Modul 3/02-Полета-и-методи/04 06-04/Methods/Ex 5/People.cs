using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_5
{
    public class People
    {
        private List<Person> peoples = new List<Person>();

        public List<Person> Peoples
        {
            get { return peoples; }
            set { peoples = value; }
        }

        public void AddPerson(Person person)
        {
            this.peoples.Add(person);
        }
        public People PeopleOver30(List<Person> people)
        {
            People peopleOver30 = new People();
            foreach (var p in this.peoples.OrderBy(n => n.Name).Where(a => a.Age > 30))
            {
                peopleOver30.AddPerson(p);
            }
            return peopleOver30;
        }
    }
}
