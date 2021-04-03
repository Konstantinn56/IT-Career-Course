using System;
using System.Collections.Generic;
using System.Linq;

namespace asdfg
{
    class Program
    {
        static void Main(string[] args)
        {
            int productsCount = int.Parse(Console.ReadLine());

            int treadmillPrice = 5899;
            int crossTrainerPrice = 1699;
            int exerciseBikePrice = 1789;
            int dumbellsPrice = 579;
            double sum = 0;
            for (int i = 0; i < productsCount; i++)
            {
                string currentProduct = Console.ReadLine();
                switch (currentProduct)
                {
                    case "treadmill":
                        sum += treadmillPrice;
                        break;
                    case "cross trainer":
                        sum += crossTrainerPrice;
                        break;
                    case "exercise bike":
                        sum += exerciseBikePrice;
                        break;
                    case "dumbbells":
                        sum += dumbellsPrice;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
