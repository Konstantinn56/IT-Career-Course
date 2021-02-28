using System;
using System.Linq;

namespace asdf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Nums = Console.ReadLine()//1 2 3 7 9
                .Split()
                .Select(int.Parse)
                .ToArray();
            int num = int.Parse(Console.ReadLine());//4
            int[] AllNums = new int[Nums.Length + 1];
            int index = 0;
            for (int i = 0; i < Nums.Length; i++)
            {
                AllNums[i] = Nums[i];
                index++;
            }
            AllNums[index] += num;

            
            for (int i = 0; i < AllNums.Length; i++)
            {
                int swapVar = AllNums[i];
                int indexx = i;
                while (indexx > 0 && AllNums[indexx - 1] >= swapVar)
                {
                    AllNums[indexx] = AllNums[indexx - 1];
                    indexx--;
                }
                AllNums[indexx] = swapVar;

            }
            Console.WriteLine(string.Join(" ", AllNums));

        }
    }
}
