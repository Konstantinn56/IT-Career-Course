using System;
using System.Linq;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            //0 1   2 3 4 5   6 7
            //1 2   3 4 5 6   7 8
            //////////////////////////////////////////////////
            int[] firstLine = new int[nums.Length / 2];
            int index = 0;
            for (int i = nums.Length / 4 - 1; i >= 0; i--)
            {
                firstLine[index] = nums[i];
                index++;
            }
            
            for (int i = nums.Length-1; i > nums.Length-1 - nums.Length/4 ; i--)
            {
                firstLine[index] = nums[i];
                index++;
            }
            //////////////////////////////////////////////////
            index = 0;
            int[] secondLine = new int[nums.Length / 2];
            for (int i = nums.Length/4; i < nums.Length - nums.Length/4; i++)
            {
                secondLine[index] = nums[i];
                index++;
            }
            //////////////////////////////////////////////////
            int[] sumLine = new int[nums.Length/2];
            for (int i = 0; i < nums.Length/2; i++)
            {
                sumLine[i] = firstLine[i] + secondLine[i];
            }
            Console.WriteLine(string.Join(" ", sumLine));
        }
    }
}
