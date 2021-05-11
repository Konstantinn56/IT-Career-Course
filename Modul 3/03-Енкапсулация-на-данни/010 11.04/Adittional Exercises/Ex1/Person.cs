using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class Person
    {
        private string name;
        private string lastName;
        private int age;
        private double salary;
        public Person(string name, string lastName, int age, double salary)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
