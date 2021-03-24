using System;
using System.Collections.Generic;

namespace hgfhgf
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(",");
            //56,87,9999,45,12,35,44,51,21

            List<string> groupOne = new List<string>();
            List<string> groupTwo = new List<string>();
            List<string> groupThree = new List<string>();
            List<string> groupFour = new List<string>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = int.Parse(nums[i]);
                
                if(currentNum % 2 == 0 && currentNum % 10 == 2 || currentNum % 10 == 4)
                {
                    groupOne.Add(nums[i]);
                }
                if(currentNum % 2 != 0 && currentNum % 10 == 5 || currentNum % 10 == 7)
                {
                    groupTwo.Add(nums[i]);
                }
                
                if (DoesSumOfNumsEndOn3(nums[i]))
                {
                    groupThree.Add(nums[i]);
                }
                if (DoesSumOfNumsEndOn6(nums[i]))
                {
                    groupFour.Add(nums[i]);
                }

            }
            PrintAllGroupsAndSpaceBetweenThem(groupOne, groupTwo, groupThree, groupFour);
            
            
            
        }
        static void PrintAllGroupsAndSpaceBetweenThem(List<string> g1 , List<string> g2, List<string> g3, List<string> g4)
        {
            Console.WriteLine(string.Join(",",g1));
            Console.WriteLine();
            Console.WriteLine(string.Join(",", g2));
            Console.WriteLine();
            Console.WriteLine(string.Join(",", g3));
            Console.WriteLine(); 
            Console.WriteLine(string.Join(",", g4));

        }

        static bool DoesSumOfNumsEndOn6(string nums)
        {

            bool doesSumEndOn6 = false;

            int num = int.Parse(nums);
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += num % 10;
                num = num / 10;
            }

            if(sum % 10 == 6)
            {
                doesSumEndOn6 = true;
            }
            return doesSumEndOn6;
            
        }
        static bool DoesSumOfNumsEndOn3(string nums)
        {

            bool doesSumEndOn3 = false;

            int num = int.Parse(nums);
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += num % 10;
                num = num / 10;
            }

            if (sum % 10 == 3)
            {
                doesSumEndOn3 = true;
            }
            return doesSumEndOn3;

        }

    }
}
