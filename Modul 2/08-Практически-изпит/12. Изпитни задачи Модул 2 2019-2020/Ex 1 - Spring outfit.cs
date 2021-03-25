using System;

namespace sdfgg
{
    class Program
    {
        static void Main(string[] args)
        {
            int productsCount = int.Parse(Console.ReadLine());

            double sumPrice = 0;

            for (int i = 0; i < productsCount; i++)
            {
                string product = Console.ReadLine();
                switch (product)
                {
                    case "jeans":
                        sumPrice += 50;
                        break;

                    case "t-shirt":
                        sumPrice += 20;
                        break;

                    case "jacket":
                        sumPrice += 60;
                        break;
                    case "trainers":
                        sumPrice += 70;
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine($"{sumPrice:f2}");
        }
    }
}
