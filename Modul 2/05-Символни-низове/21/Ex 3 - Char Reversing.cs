using System;

namespace sgb
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            PrintReversedChr(word.Length, word);
        }
        static void PrintReversedChr(int Length, string word)
        {
            char[] reversedSymbols = new char[Length];
            int index = 0;
            for (int i = Length - 1; i >= 0; i--)
            {
                reversedSymbols[index] = word[i];
                index++;
            }
            foreach (var symbols in reversedSymbols)
            {
                Console.Write(symbols);
            }
        }
    }
}
