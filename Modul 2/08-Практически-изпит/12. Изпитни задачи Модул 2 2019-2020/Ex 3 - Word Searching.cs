using System;
using System.Collections.Generic;

namespace ghjkkk
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
                string currentWord = Console.ReadLine();

                if (IsTheWordStartWithUpperLetter(currentWord) && DoesTheWordContainsLetterI(currentWord) && IsTheWordLengthAbove7(currentWord))
                {
                    specialWords.Add(currentWord);
                }
                else
                {
                    otherWords.Add(currentWord);
                }
            }
            PrintSpecialAndOtherWords(specialWords, otherWords);
            
        }
        static void PrintSpecialAndOtherWords(List<string> specialWords, List<string> otherWords)
        {
            Console.WriteLine($"Special words: {string.Join(", ",specialWords)}");
            Console.WriteLine($"Other words: {string.Join(", ",otherWords)}");
        }
        static bool IsTheWordStartWithUpperLetter(string currentWord)
        {
            bool isIt = false;

            if(currentWord[0].ToString() == currentWord[0].ToString().ToUpper())
            {
                isIt = true;
            }
            return isIt;
        }
        static bool DoesTheWordContainsLetterI(string currentWord)
        {
            bool isIt = false;

            if (currentWord.Contains("i") || currentWord.Contains("I"))
            {
                isIt = true;
            }
            return isIt;
        }

        static bool IsTheWordLengthAbove7(string currentWord)
        {
            bool isIt = false;
            
            if(currentWord.Length > 7)
            {
                isIt = true;
            }
            return isIt;
        }
    }
}
