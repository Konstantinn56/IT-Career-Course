using System;
using System.Collections.Generic;
using System.Linq;

namespace Modul_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            //INDEX 0 1 2 3 4 5
            //TODO: 8 2 2 4 8 16
            //TODO: 8 4 4 8 16
            //TODO: 8 8 8 16
            //TODO: 16 8 16

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if(nums[i] == nums[i + 1])
                {
                    nums[i + 1] = nums[i] + nums[i + 1];
                    nums.RemoveAt(i);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ",nums));
        }

    }
}
