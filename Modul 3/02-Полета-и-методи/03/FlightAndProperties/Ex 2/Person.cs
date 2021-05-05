using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return $"{name} - {age}";
        }
    }
}
