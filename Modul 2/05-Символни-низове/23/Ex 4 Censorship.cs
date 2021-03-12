using System;

namespace gjk
{
    class Program
    {
        static void Main(string[] args)
        {
            string banWord = Console.ReadLine();
            string text = Console.ReadLine();

            if (text.Contains(banWord))
            {
                text = text.Replace(banWord, new string('*', banWord.Length));
            }
            Console.WriteLine(text);

        }
    }
}
