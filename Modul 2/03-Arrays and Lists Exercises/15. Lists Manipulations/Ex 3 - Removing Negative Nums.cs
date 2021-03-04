using System;
using System.Collections.Generic;
using System.Linq;

namespace hdfh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            //7 -2 -10 1
            List<int> NewNums = new List<int>();

            int temp = 0;
            for (int i = nums.Count-1; i >= 0; i--)
            {
                if(nums[i] >= 0)
                {
                    NewNums.Add(nums[i]);
                    temp++;
                }
            }
            if(temp != 0)
            {
                Console.WriteLine(string.Join(" ", NewNums));
            }
            else
            {
                Console.WriteLine("Empty");
            }
            
        }
    }
}
