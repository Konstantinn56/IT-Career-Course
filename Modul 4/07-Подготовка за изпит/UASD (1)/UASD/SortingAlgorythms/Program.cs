using System;
using System.Linq;

namespace SortingAlgorythms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 5, 2, 5, 1, 6, 3 };
            //Console.WriteLine(string.Join(" ", array));
            //Console.WriteLine(string.Join(" ", SelectionSort(array)));


            //Sorting.Sort(array);

            //Console.WriteLine(string.Join(" ", array));

            //string[] str = new string[] { "Bobi", "Sisi", "Mimi", "Ani", "Kiro", "Dari" };
            //Console.WriteLine(string.Join(" ", str));
            //Sorting.Sort(str);
            //Console.WriteLine(string.Join(" ", str));

            //int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Sorting.SortDecsending(array);

            //int[] positions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //Console.WriteLine($"{array[positions[0] - 1]} {array[positions[1] - 1]}");
            //int[] array = new int[] { 5, 2, 5, 1, 6, 3 };
            //Sorting.InsertionSort(array);
            //Console.WriteLine(string.Join(" ", array));
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] leftArray = new int[array.Length/2];
            int[] rightArray = new int[array.Length/2];

            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = array[i];
            }
            Console.WriteLine(string.Join(" ", leftArray));

            for (int i = array.Length / 2, j = 0; i < array.Length; i++, j++)
            {
                rightArray[j] = array[i];
            }

            Console.WriteLine(string.Join(" ", rightArray));
            Sorting.Sort(leftArray);
            Sorting.SortDecsending(rightArray);

            Console.WriteLine(string.Join(" ", leftArray));
            Console.WriteLine(string.Join(" ", rightArray));
        }

        public static void InsertionSort(int[] array)
        {
            //0  1  2  3  4  5
            //2, 5, 5, 1, 6, 3
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while(j >= 0 && key < array[j])
                {
                    array[j + 1] = array[j];
                    j = j - 1;//-1
                    //Console.WriteLine(string.Join(" ", array));
                }
                array[j + 1] = key;
            }
        }
        public static void BubbleSortWithFor(int[] array)
        {
            //0  1  2  3  4  5
            //5, 2, 5, 1, 6, 3
            for (int j = 0; j < array.Length-j-1; j++)
            {
                for (int i = 0; i < array.Length - j - 1; i++)
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

        public static void BubbleSortWithWhile(int[] array)
        {
            bool swapped = false;
            do
            {
                //0  1  2  3  4  5
                //5, 2, 5, 1, 6, 3
                swapped = false;
                for (int i = 0; i < array.Length - i - 1; i++)
                {
                    if (array[i] > array[i+1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }                
            }
            while (swapped);
        }

        public static int[] SelectionSort(int[] array)
        {
            //0  1  2  3  4  5
            //5, 2, 5, 1, 6, 3
            for (int index = 0; index < array.Length; index++)
            {
                int minIndex = index;

                for (int currIndex = index + 1; currIndex < array.Length; currIndex++)
                {
                    if(array[currIndex] < array[minIndex])
                    {
                        minIndex = currIndex;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[index];
                array[index] = temp;
            }

            return array;
        }
    }
}
