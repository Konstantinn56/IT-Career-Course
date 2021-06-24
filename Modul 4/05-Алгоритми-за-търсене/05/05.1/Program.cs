using System;

namespace _05._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool LinearSearch(int[] array, int number)
        {
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if(number == array[i])
                {
                    isFound = true;
                    return isFound;
                }
            }

            return isFound;
        }
        public static bool BinarySearch(int[] array, int number, int start , int end)
        {
            bool isFound = false;
            if(end < start)
            {
                isFound = false;
                return isFound;
            }
            else
            {
                int mid = (start + end) / 2;
                if(array[mid] > number)
                {
                    return BinarySearch(array, number, start, mid - 1);
                }
                else if(array[mid] < number)
                {
                    return BinarySearch(array, number, mid + 1, end);
                }
                if(array[mid] == number)
                {
                    isFound = true;
                    return isFound;
                }
            }
            
            
            return isFound;
        }
        public static int InterpolationSearch(int [] array , int key)
        {
            int low = 0;
            int high = array.Length - 1;

            while (array[low] <= key && array[high] >= key)
            {
                int mid = low + ((key - array[low]) * (high - low)) / (array[high] - array[low]);
                    
                if (key < array[mid])
                {
                    high = mid - 1;
                }
                else if(key > array[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
