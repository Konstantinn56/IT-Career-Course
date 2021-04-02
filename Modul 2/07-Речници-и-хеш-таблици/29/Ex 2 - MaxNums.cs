using System;
using System.Collections.Generic;
using System.Linq;

namespace dghjh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(X => X)
                .Take(3)
                .ToList();

            Console.WriteLine($"{string.Join(" ",nums)}");
        }
    }
}
