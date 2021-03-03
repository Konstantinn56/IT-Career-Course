using System;
using System.Collections.Generic;
using System.Linq;

namespace dfgh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            //5 4 8 5 7 8 2 1
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            int MinNumberCount = 0;
            int MaxNumberCount = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                
                if(nums[i] < minNumber)
                {
                    minNumber = nums[i];              
                }
                if(nums[i] > maxNumber)
                {
                    maxNumber = nums[i];
                }
            }
            
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == minNumber)
                {
                    MinNumberCount++;
                }
                if (nums[i] == maxNumber)
                {
                    MaxNumberCount++;
                }
            }
            if(minNumber == maxNumber)
            {
                for (int a = 0; a < MinNumberCount; a++)
                {
                    Console.Write($"{minNumber} ");
                }
            }
            else
            {
                for (int a = 0; a < MinNumberCount; a++)
                {
                    Console.Write($"{minNumber} ");
                }
                for (int a = 0; a < MaxNumberCount; a++)
                {
                    Console.Write($"{maxNumber} ");
                }
            }

        }
    }
}
