using System;

namespace fghn
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaiseToPower(num, power);
            Console.WriteLine(result);
        }
        static double RaiseToPower(double num , int power)
        {
            double result = Math.Pow(num, power);
            return result;
        }
    }
}
