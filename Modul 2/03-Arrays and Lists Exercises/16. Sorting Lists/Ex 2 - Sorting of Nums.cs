using System;
using System.Collections.Generic;
using System.Linq;

namespace oup_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            //8 2 7 3
            //0 1 2 3

            for (int i = 0; i < nums.Count; i++)
            {
                double SwapVar = nums[i];
                int index = i;

                while(index > 0 && nums[index - 1] >= SwapVar)
                {
                    nums[index] = nums[index - 1];
                    index--;
                }
                nums[index] = SwapVar;
            }
            Console.WriteLine(string.Join(" <= ",nums));
        }
    }
}
