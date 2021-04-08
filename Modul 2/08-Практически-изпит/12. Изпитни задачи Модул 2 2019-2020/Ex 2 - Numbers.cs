using System;
using System.Collections.Generic;
using System.Linq;

namespace nvmm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            List<int> firstGroup = new List<int>();
            List<int> secondGroup = new List<int>();
            List<int> thirdGroup = new List<int>();
            List<int> fourthGroup = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (DoesTheNumEndOn(num, 2, 4))
                {
                    firstGroup.Add(num);
                }
                else if (DoesTheNumEndOn(num, 5, 7))
                {
                    secondGroup.Add(num);
                }
                if (DoesTheNumSumEndOn(num, 3))
                {
                    thirdGroup.Add(num);
                }
                else if (DoesTheNumSumEndOn(num, 6))
                {
                    fourthGroup.Add(num);
                }
            }
            PrintGroup(firstGroup);
            PrintGroup(secondGroup);
            PrintGroup(thirdGroup);
            Console.WriteLine(string.Join(",", fourthGroup));

        }
        static void PrintGroup(List<int> group)
        {
            Console.WriteLine(string.Join(",",group));
            Console.WriteLine();
        }
        static bool DoesTheNumEndOn(int num, int endingNum1, int endingNum2)
        {
            bool isTrue = false;
            
            if(num % 10 == endingNum1 || num % 10 == endingNum2)
            {
                isTrue = true;
            }
            return isTrue;
        }
        static bool DoesTheNumSumEndOn(int num, int endingNum)
        {
            bool isTrue = false;
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            if(sum % 10 == endingNum)
            {
                isTrue = true;
            }
            return isTrue;
        }
        
    }
}
