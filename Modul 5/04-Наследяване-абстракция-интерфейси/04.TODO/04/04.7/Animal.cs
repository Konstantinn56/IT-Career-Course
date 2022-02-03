using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._7
{
    class Animal : IMakeNoise, IMakeTrick
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string n , int a)
        {
            this.Name = n;
            this.Age = a;
        }
        public virtual void MakeNoise()
        {
            Console.WriteLine($"My name is {this.Name}. I am {this.Age} years old.");
        }

        public virtual void MakeTrick()
        {
            Console.WriteLine("Look at my trick!");
        }
    }
}
