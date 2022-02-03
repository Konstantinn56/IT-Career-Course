using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._3._1
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            this.Radius = r;
        }
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }

        
    }
}
