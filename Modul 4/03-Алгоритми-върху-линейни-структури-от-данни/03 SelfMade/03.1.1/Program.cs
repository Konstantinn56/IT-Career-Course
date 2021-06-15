using System;
using System.Linq;

namespace _03._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());


            
        }
        public static void NumberCheck(int[] nums,int numToCheck)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == numToCheck)
                {
                    Console.WriteLine($"{nums[i]} Exists in the List");
                    break;
                }
                if (i == nums.Length - 1)
                {
                    Console.WriteLine($"{numToCheck} Not exists in the List");
                }
            }
        }
        public static void InsertMethod(int[] nums, int numToInsert)
        {
            int[] oldNums = new int[nums.Length];
            for (int i = 0; i < oldNums.Length; i++)
            {
                oldNums[i] = nums[i];
            }

            int[] newNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
            }



        }
    }
}
