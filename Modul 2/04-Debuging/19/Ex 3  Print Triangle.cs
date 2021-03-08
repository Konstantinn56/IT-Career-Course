using System;

namespace kk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //3

            PrintWholeTriangle(n);

            //1
            //1 2
            //1 2 3
            //1 2
            //1
        }
        static void PrintFirstPart(int n)
        {
            for (int i = 0; i < n; i++)
            {
                PrintLine(1, i + 1);
            }
        }
        static void PrintLastPart(int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
            Console.WriteLine();
        }
        static void PrintWholeTriangle(int n)
        {
            PrintFirstPart(n);
            PrintLastPart(n);
        }
        static void PrintLine(int start ,int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        
    }
}
