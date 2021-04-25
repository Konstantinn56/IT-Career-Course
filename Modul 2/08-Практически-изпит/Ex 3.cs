using System;

namespace ghj
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int maxPoints = int.MinValue;
            string maxWord = null;

            while (!word.Equals("END OF GAME"))
            {
                string currentWord = word;
                int wordPoints = GetWordsPoints(currentWord);
                if(wordPoints > maxPoints)
                {
                    maxPoints = wordPoints;
                    maxWord = currentWord;
                }
                word = Console.ReadLine();
            }
            Console.WriteLine($"Winner is word: {maxWord}");
            Console.WriteLine($"Points: {maxPoints}");
        }
        static int GetWordsPoints(string word)
        {
            int wordPoints = 0;
            foreach (char c in word)
            {
                wordPoints += System.Convert.ToInt32(c);
            }
            if (word[0].ToString().Equals(word[0].ToString().ToUpper()))
            {
                wordPoints += 15;
            }
            if(word[word.Length - 1].ToString().Equals("t"))
            {
                wordPoints += 20;
            }
            if(word.Length >= 10)
            {
                wordPoints += 30;
            }
            return wordPoints;
        }
    }
}
