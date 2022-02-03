using System;

namespace _06._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int k = 2;
            int[] array = new int[k];
            Combinations(array, 0, 1);
            Console.WriteLine(string.Join(" ",array));
        }
        public static void Combinations(int[] array, int index, int start)
        {
             if(index >= array.Length)
             {
                Console.WriteLine(string.Join(" ",array));
             }

            for (int i = start; i <= array.Length; i++)
            {
                array[index] = i;
                Combinations(array, index++, start++);
            }
        }
    }
}
