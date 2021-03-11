using System;

namespace sdfgh
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string pattern = Console.ReadLine();
            //astalavista baby
            //sta
            while (word.Contains(pattern))
            {
                int startIndex = word.IndexOf(pattern);
                word = word.Remove(startIndex, pattern.Length);

                int endIndex = word.LastIndexOf(pattern);
                word = word.Remove(endIndex,pattern.Length);

                pattern = pattern.Remove(pattern.Length / 2, 1);
                Console.WriteLine("Shake it");
            }
            Console.WriteLine("No Shake");
            Console.WriteLine(word);

        }
        

            
    }
}
