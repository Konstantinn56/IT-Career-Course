using System;

namespace SearchingAlgorythms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 1;
            Console.WriteLine(InterpolationSearch(array, key));
        }

        public static int InterpolationSearch(int[]array, int key)
        {
            int low = 0;
            int high = array.Length - 1;

            while(array[low] <= key && array[high] >= key)
            {
                int mid = low + ((key - array[low]) * (high - low)) / (array[high] - array[low]);

                if (key < array[mid])
                {
                    //return BinarySearchRecursion(array, key, start, mid - 1);
                    high = mid - 1;
                }
                else if (key > array[mid])
                {
                    //return BinarySearchRecursion(array, key, mid + 1, end);
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
        public static int BinarySearchRecursion(int[] array, int key, int start,int end)
        {
            if(end == start)
            {
                return -1;
            }
            else
            {
                int mid = (start + end) / 2;
                if(key < array[mid])
                {
                    return BinarySearchRecursion(array, key, start, mid - 1);
                }
                else if (key > array[mid])
                {
                    return BinarySearchRecursion(array, key, mid + 1, end);
                }
                else
                {
                    return mid;
                }
            }
        }

        public static int BinarySearch(int[] array, int key, int start, int end)
        {
            while(end != start)
            {
                int mid = (start + end) / 2;
                if (key < array[mid])
                {
                    //return BinarySearchRecursion(array, key, start, mid - 1);
                    end = mid - 1;
                }
                else if (key > array[mid])
                {
                    //return BinarySearchRecursion(array, key, mid + 1, end);
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
        public static bool LinearSearch(int[] array,int number)
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
    }
}
