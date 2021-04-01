using System;
using System.Collections.Generic;
using System.Linq;

namespace cbnnn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Select(w => w.ToLower()).ToArray();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            for (int word = 0; word < words.Length; word++)
            {
                if (!wordsCount.ContainsKey(words[word]))
                {
                    wordsCount.Add(words[word], 1);
                }
                else
                {
                    wordsCount[words[word]]++;
                }
            }

            foreach (var w in wordsCount)
            {
                if(w.Value % 2 == 0)
                {
                    wordsCount.Remove(w.Key);
                }
                
            }
            Console.WriteLine(string.Join(", ", wordsCount.Keys));
            

        }
    }
}
