using System;

namespace AdditionalTask_6_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] array = new int[n];

            //for (int i1 = 1; i1 <= n; i1++)
            //{
            //    for (int i2 = 1; i2 <= n; i2++)
            //    {
            //        Console.WriteLine($"{i1} {i2}");
            //    }
            //}
            InnerLoops(array, 0);

        }

        public static void InnerLoops(int[] array, int index)
        {
            if(index > array.Length - 1)
            {
                Console.WriteLine(string.Join(" ", array));
            }

            for (int i = 1; i <= array.Length && index < array.Length; i++)
            {
                array[index] = i;
                InnerLoops(array, index + 1);
            }
        }

    }
}
