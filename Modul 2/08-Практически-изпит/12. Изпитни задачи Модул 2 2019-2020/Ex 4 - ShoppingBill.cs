using System;
using System.Collections.Generic;

namespace wretrwtt
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productsNamesAndPrices = new Dictionary<string, double>();

            string[] command = Console.ReadLine().Split('-');
            double totalSum = 0;
            while (!command[0].Equals("STOP SHOPPING"))
            {
                string product = command[0];
                double productPirce = double.Parse(command[1]);
                if (!productsNamesAndPrices.ContainsKey(product))
                {
                    productsNamesAndPrices.Add(product, 0.0);
                }
                productsNamesAndPrices[product] += productPirce;
                totalSum += productPirce;
                command = Console.ReadLine().Split('-');
            }
            foreach (var p in productsNamesAndPrices)
            {
                Console.WriteLine($"{p.Key} -> {p.Value:f2}");
            }
            Console.WriteLine($"Total sum: {totalSum:f2}");
        }
    }
}
