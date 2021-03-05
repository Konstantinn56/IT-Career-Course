using System;
using System.Collections.Generic;
using System.Linq;

namespace ахсфх
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            //3 16 4 5 6 8 9 
            List<int> squareNums = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (Math.Sqrt(nums[i]) == (int)Math.Sqrt(nums[i]))
                {
                    squareNums.Add(nums[i]);
                }
            }
            for (int i = 0; i < squareNums.Count; i++)
            {
                int swapVar = squareNums[i];
                int index = i;
                while (index > 0 && squareNums[index - 1] >= swapVar)
                {
                    squareNums[index] = squareNums[index - 1];
                    index--;
                }
                squareNums[index] = swapVar;

            }
            squareNums.Reverse();
            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
