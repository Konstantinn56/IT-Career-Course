using System;
using System.Collections.Generic;

namespace Ex_3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordsCount = int.Parse(Console.ReadLine());

            List<string> specialWords1 = new List<string>();
            List<string> specialWords2 = new List<string>();
            List<string> otherWords = new List<string>();
            
            for (int i = 0; i < wordsCount; i++)
            {
                int temp = 0;
                string word = Console.ReadLine();
                if (DoesTheFirstLetterEqualsLastLetter(word))
                {
                    specialWords1.Add(word);
                    temp++;
                }
                if (DoesTheWordContainsTwoOrMoreLettersA(word))
                {
                    specialWords2.Add(word);
                    temp++;
                }
                if(temp == 0)
                {
                    otherWords.Add(word);
                }

            }
            Console.WriteLine(string.Join(",", specialWords1));
            Console.WriteLine(string.Join(",", specialWords2));
            Console.WriteLine(string.Join(",", otherWords));
        }
        static bool DoesTheFirstLetterEqualsLastLetter(string word)
        {
            bool isTrue = false;
            if(word[0].Equals(word[word.Length - 1]))
            {
                isTrue = true;
            }
            return isTrue;
        }
        static bool DoesTheWordContainsTwoOrMoreLettersA(string word)
        {
            bool isTrue = false;
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].ToString().Equals("a"))
                {
                    counter++;
                }
                if(counter >= 2)
                {
                    isTrue = true;
                    break;
                }
            }
            return isTrue;
        }
    }
}
