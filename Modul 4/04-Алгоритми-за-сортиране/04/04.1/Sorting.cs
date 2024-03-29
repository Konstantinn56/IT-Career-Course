﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04._1
{
    public class Sorting
    {
        public static void SelectionSort<T>(T[] nums) where T : IComparable
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int minIndex = i;
                for (int a = i + 1; a < nums.Length; a++)
                {
                    if (Less(nums[a] , nums[minIndex]))
                    {
                        minIndex = a;
                    }
                }
                Swap(nums, minIndex, i);
                Console.WriteLine($"Array: {string.Join(" ", nums)}");
            }
        }
        public static void SelectionSortByDescending<T>(T[] nums) where T : IComparable
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int minIndex = i;
                for (int a = i + 1; a < nums.Length; a++)
                {
                    if (!Less(nums[a], nums[minIndex]))
                    {
                        minIndex = a;
                    }
                }
                Swap(nums, minIndex, i);
            }
        }
        public static void BubbleSort<T>(T[] array)where T : IComparable
        {
            //            7
            //0 1 2 3 4 5 6
            //6 5 4 3 2 0 1
            
            for (int a = 0; a < array.Length - 1; a++)
            {
                for (int i = 0; i < array.Length - a - 1; i++)
                {
                    if(!Less(array[i] , array[i + 1]))
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }
        public static void BubbleSortWithWhile<T>(T[] array) where T : IComparable
        {
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (!Less(array[i] , array[i + 1]))
                    {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                }
                
            }
            while (swapped);
           

        }//bad
        public static void InsertionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;
                while (j >= 0 && key.CompareTo(array[j]) < 0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }

        private static bool Less<T>(T firstItem , T secondItem) where T : IComparable
        {
            return firstItem.CompareTo(secondItem) < 0;
            //nums[a] < nums[minIndex] trqbva da vurne -1
        }
        private static void Swap<T>(T[] array, int from, int to) where T : IComparable
        {
            T temp = array[from];
            array[from] = array[to];
            array[to] = temp;
        }
    }
}
