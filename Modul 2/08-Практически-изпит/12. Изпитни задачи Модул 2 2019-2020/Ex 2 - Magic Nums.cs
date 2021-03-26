using System;
using System.Collections.Generic;
using System.Linq;

namespace sfdgg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

            List<int> firstGr = new List<int>();
            List<int> secondGr = new List<int>();
            List<int> thirdGr = new List<int>();


            for (int i = 0; i < nums.Length; i++)
            {
                if (IsTheNumEvenAndEndOn4Or8(nums[i]))
                {
                    firstGr.Add(nums[i]);
                }
                if (IsTheNumOddAndEndOn5Or7(nums[i]))
                {
                    secondGr.Add(nums[i]);
                }
                if (IsTheSumOfDigitsEquals15(nums[i]))
                {
                    thirdGr.Add(nums[i]);
                }
            }
            PrintAllGroups(firstGr, secondGr, thirdGr);
            
        }
        static void PrintAllGroups(List<int> firstGr , List<int> secondGr, List<int> thirdGr)
        {
            Console.WriteLine(string.Join(", ",firstGr));
            Console.WriteLine(string.Join(", ",secondGr));
            Console.WriteLine(string.Join(", ",thirdGr));
        }
        static bool IsTheNumEvenAndEndOn4Or8(int num)
        {
            bool isIt = false;
            if(num % 2 == 0 && num % 10 == 4 || num % 10 == 8)
            {
                isIt = true;
            }
            return isIt;

        }
        static bool IsTheNumOddAndEndOn5Or7(int num)
        {
            bool isIt = false;
            if (num % 2 != 0 && num % 10 == 5 || num % 10 == 7)
            {
                isIt = true;
            }
            return isIt;
        }
        static bool IsTheSumOfDigitsEquals15(int num)
        {
            bool isIt = false;
            double sum = 0;

            int numLength = (num.ToString()).Length;
            for (int l = 0; l < numLength; l++)
            {
                sum += num % 10;
                num = num/10;
            }

            if(sum == 15)
            {
                isIt = true;
            }
            return isIt;
        }
    }
}
