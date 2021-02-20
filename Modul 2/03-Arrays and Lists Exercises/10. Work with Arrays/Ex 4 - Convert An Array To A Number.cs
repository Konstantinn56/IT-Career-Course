using System;
using System.Linq;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 10 3
            //12 13
            //25
            int[] nums = Console.ReadLine()//2 10 3
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (nums.Length > 1)
            {
                int[] condensed = new int[nums.Length - 1];

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }

                nums = condensed;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
