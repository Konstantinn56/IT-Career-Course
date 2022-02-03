using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Village
{
    public class Rebel : Person
    {
        private int harm;

        public Rebel(string name, int age, int harm) : base(name, age)
        {
            this.Harm = harm;
        }

        public int Harm
        {
            get { return harm; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Harm should be greater than 0!");
                }
                harm = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Harm: {this.Harm}");
            return sb.ToString();
        }
    }
}


