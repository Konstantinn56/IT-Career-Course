using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary = 0;

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName
        {
            get { return this.firstName; }
        }
        public string LastName
        {
            get { return this.lastName; }
        }
        public int Age
        {
            get { return this.age; }
        }

        public void IncreaseSalary(double percent)
        {
            if(this.Age > 30)
            {
                this.salary += this.salary * percent / 100;
            }
            else
            {
                this.salary += this.salary * percent / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
        }
    }
}
