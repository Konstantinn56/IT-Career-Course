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

            SumAndAverage(nums);
            
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
                else if (i == nums.Length - 1)
                {
                    Console.WriteLine($"{numToCheck} Not exists in the List");
                }
            }
        }
        public static void InsertMethod(int[] nums, int numToInsert)
        {
            int[] oldNums = new int[nums.Length];
            int[] newNums = new int[nums.Length + 1];
            for (int i = 0; i < oldNums.Length; i++)
            {
                oldNums[i] = nums[i];
                newNums[i] = nums[i];
            }
            newNums[nums.Length] = numToInsert;

            int temp;
            for (int j = 0; j <= newNums.Length - 2; j++)
            {
                for (int i = 0; i <= newNums.Length - 2; i++)
                {
                    if (newNums[i] > newNums[i + 1])
                    {
                        temp = newNums[i + 1];
                        newNums[i + 1] = newNums[i];
                        newNums[i] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", newNums));
            

        }
        public static void SumAndAverage(int[] nums)
        {
            int sum = 0;
            

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            decimal average = (decimal)sum / nums.Length;

            Console.WriteLine($"Sum={sum}; Average={average:f2}");
        }
    }
}
