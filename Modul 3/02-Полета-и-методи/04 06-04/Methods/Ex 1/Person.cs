using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_1
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

        public void IntroduceYourself()
        {
            Console.WriteLine($"Im {name} {age} years old!");
        }
    }
}
