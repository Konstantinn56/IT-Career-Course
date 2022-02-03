using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._2
{
    public class RacionalNumber
    {
        private int numerator;
        private int denumerator;

        public RacionalNumber(int n, int d)
        {
            
            this.Numerator = n;
            this.Denumerator = d;
        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denumerator
        {
            get { return denumerator; }
            set 
            {
                if(value <= 0)
                {
                    throw new InvalidOperationException("Denumerator must be greater than 0 !");
                }
                denumerator = value; 
            }
        }

        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denumerator}";
        }
    }
}
