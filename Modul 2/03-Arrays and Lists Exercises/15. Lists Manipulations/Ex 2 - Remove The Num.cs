using System;
using System.Collections.Generic;
using System.Linq;

namespace atjt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            //3 4 1 5 1 5 2 1
            int RepeatingTime = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == nums[nums.Count - 1])
                {
                    RepeatingTime++;
                }
            }
            int NewNumsLength = nums.Count - RepeatingTime;
            int[] NewNums = new int[NewNumsLength];
            int index = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if(nums[nums.Count - 1] != nums[i])
                {
                    NewNums[index] += nums[i];
                    index++;
                }
            }
            Console.WriteLine(string.Join(" ",NewNums));
        }
    }
}
