using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }
        public override void Eat()
        {
            Console.WriteLine("Cat eating...");
        }
    }
}
