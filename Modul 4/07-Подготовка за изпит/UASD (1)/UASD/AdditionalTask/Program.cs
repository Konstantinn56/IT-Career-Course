using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            //int[] reversed = new int[array.Length];

            //for (int i = 0; i < array.Length / 2; i++)
            //{
            //    int temp = array[i];
            //    array[i] = array[array.Length - 1 - i];
            //    array[array.Length - 1 - i] = temp;

            //    //reversed[i] = array[array.Length - 1 - i];
            //}

            Console.WriteLine(string.Join(" ", ReverseArray(array, 0)));
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

            ReverseArray(array, index + 1);

            return array;
        }
    }
}
