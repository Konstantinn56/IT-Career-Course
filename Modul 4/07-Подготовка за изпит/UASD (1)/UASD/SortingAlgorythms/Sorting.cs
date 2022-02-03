using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorythms
{
    public static class Sorting
    {
        public static void InsertionSort<T>(T[] array) where T : IComparable<T>
        {
            //0  1  2  3  4  5
            //2, 5, 5, 1, 6, 3
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;
                while (j >= 0 && key.CompareTo(array[j]) < 0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;//-1
                    //Console.WriteLine(string.Join(" ", array));
                }
                array[j + 1] = key;
            }
        }
        public static void BubbleSort<T>(T[] array) where T : IComparable<T>
        {
            //0  1  2  3  4  5
            //5, 2, 5, 1, 6, 3
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - j - 1; i++)
                {
                    //if (array[i] > array[i + 1])
                    //{
                    //    int temp = array[i];
                    //    array[i] = array[i + 1];
                    //    array[i + 1] = temp;
                    //}
                    if(!Less(array[i], array[i+ 1]))
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }

        }
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            //0  1  2  3  4  5
            //5, 2, 5, 1, 6, 3
            for (int index = 0; index < array.Length; index++)
            {
                int minIndex = index;

                for (int currIndex = index + 1; currIndex < array.Length; currIndex++)
                {
                    //array[currIndex] < array[minIndex]
                    if (Less(array[currIndex], array[minIndex]))
                    {
                        minIndex = currIndex;
                    }
                }

                Swap(array, minIndex, index);
                Console.WriteLine($"Array: {string.Join(" ", array)}");
            }
        }

        public static void SortDecsending<T>(T[] array) where T : IComparable<T>
        {
            //0  1  2  3  4  5
            //5, 2, 5, 1, 6, 3
            for (int index = 0; index < array.Length; index++)
            {
                int minIndex = index;

                for (int currIndex = index + 1; currIndex < array.Length; currIndex++)
                {
                    //array[currIndex] < array[minIndex]
                    if (!Less(array[currIndex], array[minIndex]))
                    {
                        minIndex = currIndex;
                    }
                }

                Swap(array, minIndex, index);
                //Console.WriteLine($"Array: {string.Join(" ", array)}");
            }
        }
        private static bool Less<T>(T firstItem, T secondItem) where T : IComparable<T>
        {
            return firstItem.CompareTo(secondItem) < 0;
        }

        private static void Swap<T>(T[] array, int from, int to)
        {
            T temp = array[from];
            array[from] = array[to];
            array[to] = temp;
            //Console.WriteLine($"Element: {array[from]} from Index: {to}");
            //Console.WriteLine("Swapped with:");
            //Console.WriteLine($"Element: {array[to]} from Index: {from}");
        }
    }
}
