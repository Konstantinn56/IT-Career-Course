using System;
using System.Collections.Generic;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ivan");

            School school = new School("Goethe");
            Student st = new Student("Nqkoisi" , school);

            st.Name = "asd";
            st.Adress = "asdasd";

            List<Person> people = new List<Person>();
            Dictionary<int,Person> peoples = new Dictionary<int, Person>();
            
            
            
            
        }
    }
}
