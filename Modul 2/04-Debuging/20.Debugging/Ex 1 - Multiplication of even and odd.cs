using System;

namespace util
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            //12345
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvensAndOdds(number, evenSum, oddSum);
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if(digit % 2 == 0)
                {
                    sum += number % 10;                 
                }
                number = number / 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += number % 10;
                }
                number = number / 10;
            }
            return sum;
        }
        static int GetMultipleOfEvensAndOdds(int number , int even, int odd)
        {
            even = GetSumOfEvenDigits(number);
            odd = GetSumOfOddDigits(number);
            return even * odd;
        }
    }
}
