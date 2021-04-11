using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            List<int> evenNums = new List<int>();
            List<int> oddNums = new List<int>();
            List<int> sumOfDigitsEndOn5 = new List<int>();

            for (int i = 0; i < num.Length; i++)
            {
                int n = num[i];
                if(n % 2 == 0)
                {
                    evenNums.Add(n);
                }
                else if(n % 2 != 0)
                {
                    oddNums.Add(n);
                }
                if (DoesTheSumOfDigitsEndOn5(n))
                {
                    sumOfDigitsEndOn5.Add(n);
                }
            }
            Console.WriteLine(string.Join(",",evenNums));
            Console.WriteLine(string.Join(",",oddNums));
            Console.WriteLine(string.Join(",",sumOfDigitsEndOn5));

        }
        static bool DoesTheSumOfDigitsEndOn5(int n)
        {
            bool isTrue = false;
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            if(sum % 10 == 5)
            {
                isTrue = true;
            }
            return isTrue;
        }
    }
}
