using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_4.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split('-');
            double sum = 0.0;
            Dictionary<string, double> productsList = new Dictionary<string, double>();

            while (!command[0].Equals("Stop shopping"))
            {
                string product = command[0];
                double price = double.Parse(command[1]);
                sum += price;

                if (!productsList.ContainsKey(product))
                {
                    productsList.Add(product, 0.0);
                }
                productsList[product] += price;

                command = Console.ReadLine().Split('-');
            }
            foreach (var p in productsList.OrderBy(p => p.Value))
            {
                Console.WriteLine($"{p.Key} -> {p.Value:f2}");
            }
            Console.WriteLine($"Total sum:{sum:f2}");
        }
    }
}
