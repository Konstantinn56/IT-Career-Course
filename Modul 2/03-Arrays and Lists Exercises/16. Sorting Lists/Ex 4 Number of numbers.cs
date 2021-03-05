using System;
using System.Collections.Generic;
using System.Linq;

namespace j_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                int SwapVar = nums[i];
                int index = i;
                while(index > 0 && nums[index - 1] > SwapVar)
                {
                    nums[index] = nums[index - 1];
                    index--;
                }
                nums[index] = SwapVar;
            }
            
            ///////////////////////////////////////////////////////////

            while (nums.Count > 0)
            {
                int RepeatingCounter = 1;
                int RepeatingNum = nums[0];
                for (int i = 1; i < nums.Count; i++)
                {
                    if (nums[0] == nums[i])
                    {
                        RepeatingCounter++;
                    }
                }
                nums.RemoveRange(0, RepeatingCounter);
                Console.WriteLine($"{RepeatingNum} -> {RepeatingCounter}");
            }
                
            
        }
    }
}
