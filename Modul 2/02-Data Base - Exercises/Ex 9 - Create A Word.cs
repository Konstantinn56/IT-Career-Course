using System;

namespace Ex_9___Create_A_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            string TheWord = "";
            for (int i = 0; i < rows; i++)
            {
                char symbols = char.Parse(Console.ReadLine());
                TheWord += symbols;
            }
            Console.WriteLine($"The word is: {TheWord}");
        }
    }
}
