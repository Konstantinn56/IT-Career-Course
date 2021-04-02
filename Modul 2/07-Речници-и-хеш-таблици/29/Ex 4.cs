using System;
using System.Linq;

namespace bbbb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //1 2 3 4 5 6 7 8
            int k = nums.Length / 4;
            int[] firstRowLeftSide = new int[k];
            int[] firstRowRightSide = new int[k];
            int[] firstRow = new int[2*k];
            int[] secondRow = nums.Skip(k).Take(2*k).ToArray();

            firstRowLeftSide = nums.Take(k).Reverse().ToArray();
            firstRowRightSide = nums.TakeLast(k).Reverse().ToArray();

            for (int i = 0; i < firstRowLeftSide.Length; i++)
            {
                firstRow[i] = firstRowLeftSide[i];
            }
            int index = 0;
            for (int i = k; i < firstRow.Length; i++)
            {
                firstRow[i] = firstRowRightSide[index];
                index++;
            }

            int[] sumArray = firstRow.Select((x, index) => x + secondRow[index]).ToArray();

            Print(firstRow, secondRow, sumArray);
        }
        static void Print(int[] arr, int[]arr1,int[]arrResult)
        {
            Console.WriteLine($"{string.Join(" ", arr)} +");
            Console.WriteLine($"{string.Join(" ", arr1)} =");
            Console.WriteLine($"{string.Join(" ", arrResult)}");

        }
    }
}
