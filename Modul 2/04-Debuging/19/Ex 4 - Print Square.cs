using System;

namespace jkl
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintWholeSquare(n);
            
        }
        static void PrintWholeSquare(int n)
        {
            PrintStartAndEndLine(n);
            PrintMiddleLine(n);
            PrintStartAndEndLine(n);
        }
        static void PrintStartAndEndLine(int end)
        {
            for (int i = 0; i < end * 2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        static void PrintMiddleLine(int n)
        {
            for (int i = 0; i < n/2; i++)
            {
                Console.Write("-");
                for (int a = 0; a < n - 1; a++)
                {
                    Console.Write(@"\/");
                }
                Console.Write("-");
                Console.WriteLine();
            }
        }
    }
}
