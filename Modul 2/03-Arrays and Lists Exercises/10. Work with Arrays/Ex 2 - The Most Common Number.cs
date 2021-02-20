using System;
using System.Linq;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            //4 1 1 4 2 3 4 4 1 2 4 9 3
            int MaxCount = 0;
            int RepeatingNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int repeatability = 0;
                for (int a = i; a < numbers.Length; a++)
                {
                    
                    if (numbers[i] == numbers[a])
                    {
                        repeatability++;
                    }
                        
                }
                if(repeatability > MaxCount)
                {
                    MaxCount = repeatability;
                    RepeatingNumber = numbers[i];
                }

            }
            Console.WriteLine(RepeatingNumber);
        }
    }
}
