using System;
using System.Collections.Generic;
using System.Linq;

namespace fjfjl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();//1 2 3 4 5 6

            foreach (var num in nums)
            {
                Console.WriteLine($"nums[{nums.IndexOf(num)}] = {num}");
            }
        }
    }
}
