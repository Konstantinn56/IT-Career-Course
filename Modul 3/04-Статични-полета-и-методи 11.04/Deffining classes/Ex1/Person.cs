using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class Person
    {
        private string name;
        private int age;
        private static int counter;

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
            counter++;
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }
        public static int Counter
        {
            get { return counter; }
        }
    }
}
