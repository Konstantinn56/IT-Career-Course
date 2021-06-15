using System;

namespace _03._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4 };
            int sum = Sum(array, 0);
            Console.WriteLine(sum);

            Console.WriteLine(Factorial(5));
        }

        public static void PrintFigure(int n)
        {
            if(n == 0)
            {
                return;
            }

            //pre-action
            Console.WriteLine(new string('*',n));

            //recursion
            PrintFigure(n - 1);

            //post-action
            Console.WriteLine(new string('#',n));
        }
        public static long Factorial(int num)
        {
            if(num == 0)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
        public static int Sum(int[] array, int index)
        {
            if(index >= array.Length - 1)
            {
                return array[index];
            }
            return array[index] + Sum(array, index + 1);
        }
    }
}
