using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
    public abstract class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Name should be between 3 and 30 characters!");
                }
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age should be 0 or positive!");
                }
                if (this.GetType().Name.Equals("Peasant") && value > 110)
                {
                    throw new ArgumentException("Age cannot be greater than 110!");
                }
                if (this.GetType().Name.Equals("Rebel") && value > 50)
                {
                    throw new ArgumentException("Age should be less or equal to 50!");
                }
                age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Name}");
            sb.AppendLine($"Age: {this.Age}");
            return sb.ToString();
        }
    }
}


