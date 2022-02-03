using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{

    public class Peasant : Person
    {
        private int productivity;

        public Peasant(string name, int age, int productivity) : base(name, age)
        {
            this.Productivity = productivity;
        }
        public int Productivity
        {
            get { return productivity; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Productivity cannot be less or equal to 0!");
                }
                productivity = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Productivity: {this.Productivity}");
            return sb.ToString();
        }
    }
}


