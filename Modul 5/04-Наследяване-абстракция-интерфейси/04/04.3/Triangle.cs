using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._3
{
    class Triangle : ColoredFigure
    {
        public Triangle(string color, double size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            double triangle = Math.Pow(base.Size, 2) * Math.Sqrt(3) / 4;
            return triangle;
        }
    }
}
