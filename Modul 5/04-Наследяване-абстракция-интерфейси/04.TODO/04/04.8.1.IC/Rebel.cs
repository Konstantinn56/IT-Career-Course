using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._8._1.IC
{
    class Rebel : Human
    {
        public Rebel(string name, int age) : base(name, age)
        {

        }
        public string Group { get; set; }
        public override void BuyFood()
        {
            base.Food += 5;
        }
    }
}
