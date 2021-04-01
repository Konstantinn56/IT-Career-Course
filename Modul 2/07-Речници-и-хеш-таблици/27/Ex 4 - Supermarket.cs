using System;
using System.Collections.Generic;

namespace hhh
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double>productsNameAndPrice = new Dictionary<string, double>();
            Dictionary<string, int>productsNameAndQuantity = new Dictionary<string, int>();

            string[] currentProductNameCostQuantity = Console.ReadLine().Split();

            while (!currentProductNameCostQuantity[0].Equals("stocked"))
            {
                double price = double.Parse(currentProductNameCostQuantity[1]);
                int quantity = int.Parse(currentProductNameCostQuantity[2]);
                if (!productsNameAndPrice.ContainsKey(currentProductNameCostQuantity[0]))
                {
                    productsNameAndPrice.Add(currentProductNameCostQuantity[0], price);
                    productsNameAndQuantity.Add(currentProductNameCostQuantity[0], quantity);

                }
                else
                {
                    productsNameAndPrice[currentProductNameCostQuantity[0]] = price;
                    productsNameAndQuantity[currentProductNameCostQuantity[0]] += quantity;
                }
 
                currentProductNameCostQuantity = Console.ReadLine().Split();
            }
            Console.WriteLine();
            PrintAllProductsNamesAndPrice(productsNameAndPrice, productsNameAndQuantity);
        }
        static void PrintAllProductsNamesAndPrice(Dictionary<string, double> productsNameAndCost, Dictionary<string, int> productsNameAndQuantity)
        {
            double sum = 0.00;
            foreach (var p in productsNameAndCost)
            {
                foreach (var pr in productsNameAndQuantity)
                {
                    if (p.Key.Equals(pr.Key))
                    {
                        Console.WriteLine($"{p.Key}: ${p.Value} * {pr.Value} = ${(p.Value * pr.Value):f2}");
                        sum += p.Value * pr.Value;
                    }
                }
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${sum:f2}");
        }
    }
}
