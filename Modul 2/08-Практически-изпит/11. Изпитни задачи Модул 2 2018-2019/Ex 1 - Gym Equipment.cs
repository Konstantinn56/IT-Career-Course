using System;

namespace fgh
{
    class Program
    {
        static void Main(string[] args)
        {
            int productsCount = int.Parse(Console.ReadLine());

            int priceOfProducts = 0;

            for (int i = 0; i < productsCount; i++)
            {
                string product = Console.ReadLine();

                switch (product)
                {
                    case "exercise bike":
                        priceOfProducts += 1789;
                        break;
                    case "treadmill":
                        priceOfProducts += 5899;
                        break;
                    case "dumbbells":
                        priceOfProducts += 579;
                        break;
                    case "cross trainer":
                        priceOfProducts += 1699;
                        break;

                    default:
                        Console.WriteLine("No product found!");
                        i--;
                        break;
                }
            }
            Console.WriteLine($"{priceOfProducts:f2}");
        }
    }
}
