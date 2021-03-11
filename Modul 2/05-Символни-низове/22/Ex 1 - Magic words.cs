using System;
using System.Collections.Generic;
using System.Linq;

namespace okp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            //Clint Eastwood
            //
            Console.WriteLine($"{AreTheWordsReplacable(words[0],words[1])}");
        }
        static bool AreTheWordsReplacable(string word1,string word2)
        {
            bool areReplacable = true;
            int minLength = GetMinLength(word1.Length, word2.Length);
            string maxWord = GetMaxWord(word1, word2);
            
            for (int i = 0; i < word1.Length; i++)
            {
                int word1Counter = 0;
                int word2Counter = 0;
                for (int a = 0; a < word1.Length; a++)
                {
                    if (word1[i] == word1[a])
                    {
                        word1Counter++;
                    }
                    if (word2[i] == word2[a])
                    {
                        word2Counter++;
                    }
                    if (word1Counter == word2Counter)
                    {
                        areReplacable = true;
                    }
                    else
                    {
                        areReplacable = false;
                        break;
                    }
                }
            }

            if (word1.Length != word2.Length)
            {
                List<string> newShorterWord = new List<string>();
                for (int i = 0; i < minLength; i++)
                {
                    newShorterWord.Add(maxWord[i].ToString());
                }
                for (int i = minLength; i < maxWord.Length; i++)
                {
                    if (newShorterWord.Contains(maxWord[i].ToString()))
                    {
                        areReplacable = true;
                    }
                    else
                    {
                        areReplacable = false;
                        break;
                    }
                }
            }
            return areReplacable;
        }
        static int GetMinLength(int word1Length , int word2Length)
        {
            return word1Length < word2Length ? word1Length : word2Length;
        }
        static string GetMaxWord(string word1 , string word2)
        {
            return word1.Length > word2.Length ? word1 : word2;
        }
    }
}
