using System;
using System.Collections.Generic;
using System.Linq;

namespace sdgsag
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            //3 4 4 5 5 5 2 2
            int RepeatableNum = 0;
            int RepeatableNumCount = 0;
            
            for (int i = 0; i < nums.Count; i++)
            {
                int CurrentNum = 0;
                int CurrentNumCount = 0;
                CurrentNum = nums[i];
                for (int a = 0; a < nums.Count; a++)
                {
                    if(nums[a] == CurrentNum)
                    {
                        CurrentNumCount++;
                    }
                }
                if(CurrentNumCount > RepeatableNumCount)
                {
                    RepeatableNumCount = CurrentNumCount;
                    RepeatableNum = CurrentNum;
                }
            }
            for (int i = 0; i < RepeatableNumCount; i++)
            {
                Console.Write($"{RepeatableNum} ");
            }
        }
    }
}
