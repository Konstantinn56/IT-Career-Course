using System;
using System.Collections.Generic;
using System.Linq;

namespace asad
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (var n in nums)
            {
                if (!counts.ContainsKey(n))
                {
                    counts.Add(n, 1);
                }
                else
                {
                    counts[n]++;
                }
            }
            foreach (var n in counts)
            {
                Console.WriteLine($"{n.Key} -> {n.Value}");
            }
        }
    }
}
