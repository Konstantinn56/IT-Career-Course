using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Fibonacci(10));
            int n = 3;
            int[] vector = new int[n];
            GenerateVector(vector, 0);
        }

        public static void GenerateVector(int[] vector, int index)
        {
            if (index > vector.Length - 1)
            {
                Console.WriteLine(string.Join("", vector));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    GenerateVector(vector, index + 1);
                }

            }
        }
        static decimal Fibonacci(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static long Calculate(int n)
        {
            return Calculate(n + 1);
        }

        public static void PrintFigure(int n)
        {
            if (n == 0)
            {
                return;
            }
            //pre-action
            Console.WriteLine(new string('*', n));

            //recursion
            PrintFigure(n - 1);

            //post-action
            Console.WriteLine(new string('#', n));
        }
        public static long Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
        public static int Sum(int[] array, int index)
        {
            if (index >= array.Length - 1)
            {
                return array[index];
            }
            return array[index] + Sum(array, index + 1);
        }
    }
}
