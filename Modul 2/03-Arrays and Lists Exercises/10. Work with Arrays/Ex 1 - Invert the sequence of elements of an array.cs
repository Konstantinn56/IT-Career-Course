using System;
using System.Linq;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] Numbers = new int[n];

            for (int i = 0; i < Numbers.Length; i++)
            {
                int num = int.Parse(Console.ReadLine());
                Numbers[i] = num;
            }
            
            Array.Reverse(Numbers);
            //int[] ReversedNumbers = new int[n];
            //int index = 0;
            //for (int i = Numbers.Length - 1; i >= 0; i--)
            //{
            //    ReversedNumbers[index] = Numbers[i];
            //    index++;
            //}
            foreach (var num in Numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
