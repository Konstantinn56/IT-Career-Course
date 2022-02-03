using System;

namespace _04._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle= new Triangle("Green",3);
            Console.WriteLine(triangle.GetName());
            triangle.Show();
            Console.WriteLine("Area: "+ triangle.GetArea());

        }
    }
}
