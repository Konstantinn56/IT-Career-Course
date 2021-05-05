using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_3
{
    class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email = "n/a";
        private int age = -1;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Postiion
        {
            get { return position; }
            set { position = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return $"{name} {salary:f2} {email} {age}";
        }
    }
}
