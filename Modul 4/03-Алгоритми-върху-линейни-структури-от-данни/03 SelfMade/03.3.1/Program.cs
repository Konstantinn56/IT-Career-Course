using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stck = new Stack<int>();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                stck.Push(nums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{stck.Pop()} ");
            }
        }
    }
}
