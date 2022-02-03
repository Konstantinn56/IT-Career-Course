using System;

namespace _06._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            //int[] reversed = new int[array.Length];
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
                //reversed[i] = array[array.Length - 1 - i];
            }
            //Console.WriteLine(string.Join(" ",reversed));
            Console.WriteLine(string.Join(" ",array));
        }
        public static int[] ReverseArray(int[] array, int index)
        {
            if(index > array.Length / 2)
            {
                return array;
            }
            int temp = array[index];
            array[index] = array[array.Length - 1 - index];
            array[array.Length - 1 - index] = temp;
            ReverseArray(array, index++);
            return array;
        }
    }
}
