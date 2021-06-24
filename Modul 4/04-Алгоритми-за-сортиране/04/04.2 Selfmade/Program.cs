using System;
using System.Linq;

namespace _04._2_Selfmade
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            InsertionSort(nums);
        }
        static void BubbleSort(int[] array)
        {
            //            7
            //0 1 2 3 4 5 6
            //1 5 4 3 2 0 6

            for (int a = 0; a < array.Length - 1; a++)
            {
                for (int i = 0; i < array.Length - 1 - a; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", array));
            
        }
        static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int key = array[i];
                int prev = i - 1;
                while (prev >= 0 && key.CompareTo(array[prev]) < 0)
                {
                    array[prev + 1] = array[prev];
                    Console.WriteLine($"Num:{array[prev + 1]} was coppied with {array[prev]}");
                    Console.WriteLine($"The key is: {key}");
                    Console.WriteLine(string.Join(" ", array));
                    Console.WriteLine();
                    prev--;

                }
                array[prev + 1] = key;
            }
            Console.WriteLine(string.Join(" ",array));
            
        }
    }
}
