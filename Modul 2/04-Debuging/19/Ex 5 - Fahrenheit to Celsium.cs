using System;

namespace dgh
{
    class Program
    {
        static void Main(string[] args)
        {
            double  Fahrenheit = double .Parse(Console.ReadLine());
            double Celsium = FahrenheitToCelsius(Fahrenheit);
            Console.WriteLine($"{Celsium:f2}");
        }
        static double FahrenheitToCelsius(double Fahrenheit)
        {
            double Celsium = (Fahrenheit - 32) * 5 / 9;
            return Celsium;
        }
    }
}
