using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(i + 'a');
            }

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int a = 0; a < alphabet.Length; a++)
                {
                    if (word[i].Equals(alphabet[a]))
                    {
                        Console.WriteLine($"{word[i]} -> {a}");
                    }
                }
            }
        }
    }
}
