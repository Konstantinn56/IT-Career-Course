using System;
using System.Collections.Generic;
using System.Linq;

namespace uiuziuzi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            List<int> firstGroup = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondGroup = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> thirdGroup = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> fourthGroup = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                if(currentNum % 10 == 2 || currentNum % 10 == 4)
                {
                    firstGroup.Add(currentNum);
                }
                if(currentNum % 10 == 5 || currentNum % 10 == 7)
                {
                    secondGroup.Add(currentNum);
                }
                int digitsSum = SumDigits(currentNum);
                if(digitsSum % 10 == 3)
                {
                    thirdGroup.Add(currentNum);
                }
                if (digitsSum % 10 == 6)
                {
                    fourthGroup.Add(currentNum);
                }
            }

            Console.WriteLine(string.Join(", ", firstGroup));
            Console.WriteLine(string.Join(", ", secondGroup));
            Console.WriteLine(string.Join(", ", thirdGroup));
            Console.WriteLine(string.Join(", ", fourthGroup));
        }
        public static int SumDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;

            }
            return sum;
        }
    }
}
