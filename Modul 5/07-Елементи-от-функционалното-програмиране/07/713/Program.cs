using System;
using System.Collections.Generic;
using System.Linq;

namespace _713
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> min = (nums) => nums.Min();
            Func<int[], int> min2 = (nums) => nums.OrderBy(x => x).FirstOrDefault();
            Func<int[], int> min3 = (nums) =>
            {
                int min = int.MaxValue;
                foreach (int n in nums)
                {
                    if(min > n)
                    {
                        min = n;
                    }
                }
                return min;
            };
            
        }
    }
}