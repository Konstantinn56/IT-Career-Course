using System;
using System.Collections.Generic;
using System.Linq;

namespace _721
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = numbers.Count();
            int sum = numbers.Sum();
            Console.WriteLine(sum);

            int[] result = numbers
                .Where(n => n % 2 != 0)
                .OrderBy(n => n)
                .ToArray();

            Console.WriteLine(String.Join(" ",result));
        }
    }
}