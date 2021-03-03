using System;
using System.Collections.Generic;
using System.Linq;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            //3 4 8 5 7 5 2 1

            for (int i = 0; i < nums.Count; i++)
            {
                if(nums[i] % 2 == 0)
                {
                    Console.Write($"{nums[i]} ");
                }
            }
        }
    }
}
