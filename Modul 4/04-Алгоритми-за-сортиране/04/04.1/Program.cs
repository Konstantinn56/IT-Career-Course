using System;
using System.Linq;

namespace _04._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = Console.ReadLine().Split().Select(int.Parse).ToArray();

            BubbleSort(height);
            Console.WriteLine(string.Join(" ", height));

            
        }
        public static void BubbleSort(int[] array)
        {
            for (int a = 0; a < array.Length- 1; a++)
            {
                for (int i = 0; i < array.Length - a - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            
        }
        
    }
}
