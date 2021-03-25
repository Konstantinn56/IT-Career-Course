using System;
using System.Collections.Generic;

namespace fjhk
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

                if (DoesTheWordStartAndEndWithNotTheSameLetter(word))
                {
                    if (DoesTheWordCointainsLetterE(word))
                    {
                        if (IsTheWordLengthAbove5(word))
                        {
                            specialWords.Add(word);
                        }
                        else
                        {
                            otherWords.Add(word);
                        }
                    }
                    else
                    {
                        otherWords.Add(word);
                    }
                }
                else
                {
                    otherWords.Add(word);
                }
            }
            PrintSpecialWords(specialWords);
            PrintOtherWords(otherWords);

        }
        static void PrintSpecialWords(List<string> specialWords)
        {
            Console.WriteLine($"Special words: {string.Join(",",specialWords)}");
        }
        static void PrintOtherWords(List<string> otherWords)
        {
            Console.WriteLine($"Other words: {string.Join(",", otherWords)}");
        }
        static bool DoesTheWordStartAndEndWithNotTheSameLetter(string word)
        {
            bool doesTheWordStartAndEndWithTheSameLetter = true;

            if(word[0].Equals(word[word.Length - 1]))
            {
                doesTheWordStartAndEndWithTheSameLetter = false;
            }

            return doesTheWordStartAndEndWithTheSameLetter;
        }
        static bool DoesTheWordCointainsLetterE(string word)
        {
            bool doesTheWordContainsE = false;

            if (word.Contains("e"))
            {
                doesTheWordContainsE = true;
            }
            return doesTheWordContainsE;
        }
        static bool IsTheWordLengthAbove5(string word)
        {
            bool isItRight = false;
            if(word.Length > 5)
            {
                isItRight = true;
            }
            return isItRight;
        }
    }
}
