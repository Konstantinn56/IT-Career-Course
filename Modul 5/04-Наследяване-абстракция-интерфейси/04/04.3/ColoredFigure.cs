using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._3
{
    abstract class ColoredFigure : IColoredFigure
    {
        private string color;
        private double size;

        public ColoredFigure(string color , double size)
        {
            this.Color = color;
            this.Size = size;
        }

        public string Color
        {
            get { return color;  }
            set { color = value; }
        }
        public double Size
        {
            get { return size; }
            set { size = value; }
        }

        public void Show()
        {
            Console.WriteLine($"Color: {this.Color}{Environment.NewLine}Size: {this.Size}");
        }

        public string GetName()
        {
            return $"{this.GetType().Name}";
        }

        public abstract double GetArea();
        
    }
}
