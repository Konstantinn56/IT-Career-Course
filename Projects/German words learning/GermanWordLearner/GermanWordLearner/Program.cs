using System;

namespace GermanWordLearner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fromat: (german word)-(bulgarian word)");
            Console.WriteLine("Type your words here:");

            string[] words = Console.ReadLine().Split("-");

            for (int i = 0; i < words.Length; i+=2)
            {
                Console.Write(words[i]);
                Console.Write(" - ");
                Console.Write(words[i+1]);
                Console.WriteLine();
            }
        }
    }
}
