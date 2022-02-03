using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._7
{
    class Dog: Animal
    {
        public Dog(string n , int a) : base(n, a)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Woof!");
            base.MakeNoise();
        }
        public override void MakeTrick()
        {
            Console.WriteLine("Hold my paw, human!");
        }
    }
}
