using System;
using System.Linq;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = Console.ReadLine()//a b c d e
                .Split()
                .Select(char.Parse)
                .ToArray();

            //Array.Reverse(symbols);

            char[] ReversedSymbols = new char[symbols.Length];
            int index = 0;
            for (int i = symbols.Length - 1; i >= 0; i--)
            {
                ReversedSymbols[index] = symbols[i];
                index++;
            }
            Console.WriteLine(string.Join(" ",ReversedSymbols));
        }
    }
}
