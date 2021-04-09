using System;
using System.Collections.Generic;

namespace okokk
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordCount = int.Parse(Console.ReadLine());

            List<string> specialWords = new List<string>();
            List<string> otherWords = new List<string>();

            for (int i = 0; i < wordCount; i++)
            {
                string word = Console.ReadLine();
                if(word[0] != word[word.Length - 1] && word.Contains("e") && word.Length > 5)
                {
                    specialWords.Add(word);
                }
                else
                {
                    otherWords.Add(word);
                }
            }
            Console.WriteLine($"Special words: {string.Join(", ",specialWords)}");
            Console.WriteLine($"Other words: {string.Join(", ",otherWords)}");
        }
    }
}
