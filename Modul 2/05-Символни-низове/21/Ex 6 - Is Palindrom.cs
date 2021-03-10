using System;

namespace ndng
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            //012345678910
            //alenafanela
            Console.WriteLine($"{IsPalindrom(word,word.Length)}");
        }
        static bool IsPalindrom(string word , int wordLength)
        {

            bool isPalindrom = true;
            if(wordLength == 1)
            {
                isPalindrom = true;
            }
            else
            {
                for (int i = 0; i < wordLength / 2; i++)
                {
                    if (word[i].Equals(word[wordLength - 1 - i]))
                    {
                        isPalindrom = true;
                    }
                    else
                    {
                        isPalindrom = false;
                        break;
                    }
                }
            }
            return isPalindrom;
        }
    }
}
