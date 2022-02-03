using System;

namespace AdditionalTask_6_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int k = 3;

            // k == 2 => 2 nested for-loops
            //for (int i1 = 1; i1 <= n; i1++)
            //{
            //    for (int i2 = i1; i2 <= n; i2++)
            //    {
            //        Console.WriteLine($"({i1} {i2})");
            //    }
            //}

            int[] array = new int[k];
            Combinations(array, 0, 1, n);
        }

        public static void Combinations(int[] array, int index, int start, int end)
        {
            if(index > array.Length-1)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i, end);
            }
        }
    }
}
