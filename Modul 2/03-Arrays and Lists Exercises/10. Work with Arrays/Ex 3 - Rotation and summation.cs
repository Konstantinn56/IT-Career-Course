using System;
using System.Linq;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int Rotations = int.Parse(Console.ReadLine());//1
            
            int[] SumOfRotation = new int[nums.Length];

            for (int a = 0; a < Rotations; a++)
            {
                int index = 0;
                int[] CurrentRotation = new int[nums.Length];
                
                CurrentRotation[index] = nums[nums.Length -1];
                for (int i = 0; i < nums.Length-1; i++)
                {
                    index++;
                    CurrentRotation[index] = nums[i];
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = CurrentRotation[i];
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    SumOfRotation[i] += CurrentRotation[i];
                }

            }
            Console.WriteLine(string.Join(" ", SumOfRotation));
        }
    }
}
