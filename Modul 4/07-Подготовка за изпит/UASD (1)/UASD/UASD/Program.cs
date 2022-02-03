using System;
using System.Linq;

namespace UASD
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());
            bool exist = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == number)
                {
                    exist = true;                    
                }
            }

            if (exist)
            {
                Console.WriteLine($"{number} exists in the list");
            }
            else
            {
                Console.WriteLine($"{number} not exists in the list");
            }
        }

        public static int Fibonacci(int n)
        {
            if (n == 0) return 1;
            else if (n == 1) return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
