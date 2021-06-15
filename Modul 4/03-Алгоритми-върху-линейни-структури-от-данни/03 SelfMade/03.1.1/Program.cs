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

            InsertMethod(nums, num);
            
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
            int indexToInsert = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length -1)
                {
                    if(nums[i] < numToInsert)
                    {
                        indexToInsert = i + 2;
                        break;
                    }
                }
                if (nums[0] >= numToInsert)
                {
                    indexToInsert = 0;
                    break;
                }
                if (nums[i] <= numToInsert && nums[i + 1] >= numToInsert)
                {
                    indexToInsert = i + 1;
                    break;
                }
            }

            for (int i = 0; i < indexToInsert; i++)
            {
                newNums[i] = oldNums[i];
            }
            newNums[indexToInsert] = numToInsert;
            for (int i = indexToInsert + 1; i < newNums.Length; i++)
            {
                newNums[i] = oldNums[i - 1];
            }
            newNums[newNums.Length - 1] = oldNums[oldNums.Length - 1];

            foreach (var item in newNums)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
