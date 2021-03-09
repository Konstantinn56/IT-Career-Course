using System;

namespace dhgn
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double Area = GetTriangleArea(width, height);
            Console.WriteLine(Area);
        }
        static double GetTriangleArea(double width , double height)
        {
            double Area = width * height / 2;
            return Area;
        }
    }
}
