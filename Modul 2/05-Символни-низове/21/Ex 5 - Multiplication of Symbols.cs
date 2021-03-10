using System;

namespace sdfg
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string str1 = arr[0];
            string str2 = arr[1];

            int maxLength = Math.Max(str1.Length, str2.Length);
            int minLength = Math.Min(str1.Length, str2.Length);

            double sum = Multiplication(str1, str2, minLength);

            string maxString = GetMaxString(str1.Length, str2.Length, str1, str2);

            for (int i = minLength; i < maxLength; i++)
            {
                sum += maxString[i];
            }
            Console.WriteLine(sum);

        }
        static double Multiplication(string str1, string str2, int minLength)
        {
            double sum = 0;
            for (int i = 0; i < minLength; i++)
            {
                double temp = str1[i] * str2[i];
                sum += temp;
            }
            return sum;
        }
        static string GetMaxString(int str1Length ,int str2Length, string str1 , string str2)
        {
            return str1Length > str2Length ? str1 : str2;
        }
    }
}
