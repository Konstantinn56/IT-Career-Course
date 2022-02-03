using System;

namespace _06._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int[] array = new int[n];
        }
        public static void InnerLoops(int[] array, int index)
        {
            if(index >= array.Length)
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
