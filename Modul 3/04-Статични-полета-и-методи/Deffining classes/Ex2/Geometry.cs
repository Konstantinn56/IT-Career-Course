using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    public static class Geometry
    {
        public static double SquarePerimeter(double side)
        {
            return side * 4;
        }
        public static double SquareArea(double side)
        {
            return side * side;
        }
        public static double RectanglePerimeter(double a, double b)
        {
            return a * 2 + b * 2;
        }
        public static double RectangleArea(double a, double b)
        {
            return a * b;
        }
        public static double CircleArea(double r)
        {
            return 2 * Math.Pow(r, 2) * Math.PI;
        }

    }
}
