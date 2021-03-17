using System;

namespace dghdgh
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitCoinPrice = double.Parse(Console.ReadLine());
            double ethereumPrice = double.Parse(Console.ReadLine());
            double liteCoinPrice = double.Parse(Console.ReadLine());
            int transactions = int.Parse(Console.ReadLine());

            double commisions = 0;
            double sum = 0;
            double bitCoins = 0;
            double ethereums = 0;
            double liteCoins = 0;
            for (int i = 0; i < transactions; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                string priceType = Console.ReadLine();
                string sellOrBuy = Console.ReadLine();
                //Bitcoin,Litecoin, Ethereum
                switch (priceType)
                {
                    case "Bitcoin":
                        bitCoins = quantity * bitCoinPrice;
                        commisions += bitCoins * 0.073456764216789345;
                        sum += bitCoins;
                        break;

                    case "Litecoin":
                        liteCoins = quantity * liteCoinPrice;
                        commisions += liteCoins * 0.073456764216789345;
                        sum += liteCoins;
                        break;
                    case "Ethereum":
                        ethereums = quantity * ethereumPrice;
                        commisions += ethereums * 0.073456764216789345;
                        sum += ethereums;
                        break;
                    default:
                        break;
                }
            }
            double result = sum - commisions;
            Console.WriteLine($"{result:f16}");
        }
    }
}
