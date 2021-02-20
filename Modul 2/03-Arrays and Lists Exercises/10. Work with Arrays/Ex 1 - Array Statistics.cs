using System;
using System.Linq;

namespace _03_Arrays_and_Lists_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }

                sum += numbers[i];
            }

            double average = sum / numbers.Length;
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
