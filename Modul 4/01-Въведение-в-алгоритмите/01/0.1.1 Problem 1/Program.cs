using System;
using System.Linq;

namespace _0._1._1_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            bool exist = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    exist = true;
                    break;
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
    }
}
