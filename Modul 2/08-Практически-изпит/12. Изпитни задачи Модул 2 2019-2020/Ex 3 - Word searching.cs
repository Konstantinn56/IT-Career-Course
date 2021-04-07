using System;
using System.Collections.Generic;

namespace sfggg
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordsCount = int.Parse(Console.ReadLine());

            List<string> specialWords = new List<string>();
            List<string> otherWords = new List<string>();

            for (int i = 0; i < wordsCount; i++)
            {
                string word = Console.ReadLine();
                if (DoesTheWordStartWithUpperLetter(word) && DoesTheWordContainsLetterI(word) && IsTheWordLengthAbove7(word))
                {
                    specialWords.Add(word);
                }
                else
                {
                    otherWords.Add(word);
                }

            }
            Console.WriteLine(($"Special words: {string.Join(", ", specialWords)}"));
            Console.WriteLine(($"Other words: {string.Join(", ", otherWords)}"));
        }
        static bool DoesTheWordStartWithUpperLetter(string word)
        {
            bool isTrue = false;
            if(word[0].ToString().Equals(word[0].ToString().ToUpper()))
            {
                isTrue = true;
            }
            return isTrue;
        }
        static bool DoesTheWordContainsLetterI(string word)
        {
            bool isTrue = false;
            if(word.Contains("i") || word.Contains("I"))
            {
                isTrue = true;
            }
            return isTrue;
        }
        static bool IsTheWordLengthAbove7(string word)
        {
            bool isTrue = false;
            if(word.Length > 7)
            {
                isTrue = true;
            }
            return isTrue;
        }
    }
}
