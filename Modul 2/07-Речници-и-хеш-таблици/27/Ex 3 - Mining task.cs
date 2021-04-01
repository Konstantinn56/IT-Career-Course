using System;
using System.Collections.Generic;

namespace p_lp_l
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesAndQuantity = new Dictionary<string, int>();

            string[] resourceAndQuantity = new string[2];
            resourceAndQuantity[0] = Console.ReadLine();
            resourceAndQuantity[1] = Console.ReadLine();
            while (!resourceAndQuantity[0].Equals("stop"))
            {
                if (!resourcesAndQuantity.ContainsKey(resourceAndQuantity[0]))
                {
                    resourcesAndQuantity.Add(resourceAndQuantity[0], int.Parse(resourceAndQuantity[1]));
                }
                else
                {
                    resourcesAndQuantity[resourceAndQuantity[0]] += int.Parse(resourceAndQuantity[1]);
                }
                resourceAndQuantity[0] = Console.ReadLine();
                if (resourceAndQuantity[0].Equals("stop"))
                {
                    break;
                }
                resourceAndQuantity[1] = Console.ReadLine();
            }
            foreach (var r in resourcesAndQuantity)
            {
                Console.WriteLine($"{r.Key} -> {r.Value}");
            }
        }
    }
}
