using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._8._1.IC
{
    abstract class Human : IBuyer
    {
        public Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public int Food { get; protected set; }

        public abstract void BuyFood();
    }
}
