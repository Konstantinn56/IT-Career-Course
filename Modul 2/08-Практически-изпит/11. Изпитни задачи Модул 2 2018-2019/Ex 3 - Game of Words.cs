using System;

namespace oj
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = new string[1];

            int maxWordPoints = 0;
            string maxWord = null;

            word[0] = Console.ReadLine();

            while (word[0] != "END OF GAME")
            {
                
                string currentWord = word[0];
                int currentWordPoints = 0;
                
                currentWordPoints += GetASCIIPointsOfWord(currentWord);

                char lastletter = GetLastLetter(currentWord);

                if (lastletter.Equals("t"))
                {
                    currentWordPoints += 20;
                }
                if(WordLength(currentWord) >= 10)
                {
                    currentWordPoints += 30;
                }

                if(currentWordPoints > maxWordPoints)
                {
                    maxWordPoints = currentWordPoints;
                    maxWord = currentWord;
                }
                
                word[0] = Console.ReadLine();

            }

            PrintMaxWordAndPoints(maxWord, maxWordPoints);
        }
        static int GetASCIIPointsOfWord(string word)
        {
            int points = 0;

            foreach (var l in word)
            {
                points += System.Convert.ToInt32(l);
            }

            return points;
        }
        static char GetLastLetter(string word)
        {
            char lastLetter = word[word.Length - 1];
            return lastLetter;
        }
        static int WordLength(string word)
        {
            int length = word.Length;
            return length;
        }
        static void PrintMaxWordAndPoints(string maxWord , int wordPoints)
        {
            Console.WriteLine($"Winner is word: {maxWord}");
            Console.WriteLine($"Points: {wordPoints}");
        }
    }
}
