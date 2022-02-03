using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._2
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Person(string name , int age , string city)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
        }


        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if(result == 0)
            {
                result = this.Age.CompareTo(other.Age);
                if(result == 0)
                {
                    result = this.City.CompareTo(other.City);
                }
            }
            return result;
        }
    }
}
