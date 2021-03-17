using System;

namespace sdfgfsdg
{
    class Program
    {
        static void Main(string[] args)
        {
            int agents = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < agents; i++)
            {
                int dealCount = int.Parse(Console.ReadLine());
                for (int deals = 0; deals < dealCount; deals++)
                {
                    int squareRoot = int.Parse(Console.ReadLine());
                    decimal pricePerSquare = decimal.Parse(Console.ReadLine());
                    sum += squareRoot * pricePerSquare;
                }
            }
            sum = sum / agents;
            Console.WriteLine(Math.Round(sum,3));
        }
    }
}
