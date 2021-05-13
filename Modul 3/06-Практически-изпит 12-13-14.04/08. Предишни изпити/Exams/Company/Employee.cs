using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    public class Employee
    {
        private string id;
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Employee(string id, string firstNmae, string lastName, int age)
        {
            this.Id = id;
            this.FirstName = firstNmae;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = 500.0;
        }
        public Employee(string id, string firstNmae, string lastName, int age, double salary): this(id,firstNmae,lastName,age)
        {
            this.Salary = salary;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public string Id
        {
            get { return id; }
            private set 
            { 
                id = value; 
            }
        }
        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (value.Length > 2 && value.Length < 8)
                {
                    firstName = value;
                }
                else
                    throw new ArgumentException("Invalid employee name");
                
            }
        }
        public string LastName
        {
            get { return lastName; }
            private set
            {
                lastName = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                    throw new ArgumentException("Invalid employee age");

            }
        }
        public double Salary
        {
            get { return salary; }
            private set
            {
                salary = value;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////

        public override string ToString()
        {
            return $"Employee: {this.FirstName} {this.LastName} with id: {this.Id} and salary: {this.Salary:f2}";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public void IncreaseSalaryByAmount(double amount)
        {
            this.Salary += amount;
        }
        public void DecreaseSalaryByAmount(double amount)
        {
            this.Salary -= amount;
        }

    }
}
