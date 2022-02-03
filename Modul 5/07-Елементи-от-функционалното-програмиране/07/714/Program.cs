using System;
using System.Collections.Generic;
using System.Linq;

namespace _714
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] interval = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Predicate<int> evenFinder = n => n % 2 == 0;
            Predicate<int> oddFinder = n => n % 2 != 0;

            string oddOrEven = Console.ReadLine();
            List<int> result = new List<int>();

            if (oddFinder.Equals("even"))
            {
                result = Enumerable.Range(interval[0], interval[1] - interval[0]).Where(x => evenFinder(x)).ToList();
            }
            else if (oddOrEven.Equals("odd"))
            {
                result = Enumerable.Range(interval[0], interval[1] - interval[0]).Where(x => oddFinder(x)).ToList();
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}