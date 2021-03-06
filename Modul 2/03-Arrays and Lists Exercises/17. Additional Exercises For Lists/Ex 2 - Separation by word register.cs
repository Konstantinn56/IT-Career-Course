using System;
using System.Collections.Generic;
using System.Linq;

namespace pl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(", ; : . ! ( ) \" ' \\ / [ ] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lower = new List<string>();
            List<string> upper = new List<string>();
            List<string> mixed = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].All(char.IsLower))
                {
                    lower.Add(words[i]);
                }
                else if (IsUpper(words[i]))
                {
                    upper.Add(words[i]);
                }
                else
                {
                    mixed.Add(words[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lower)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upper)}");
        }
        public static bool IsUpper(string word)
        {
            bool isUpper = false;
            foreach (var ch in word)
            {
                if (ch > 'A' && ch < 'Z')
                {
                    isUpper = true;
                }
                else
                {
                    isUpper = false;
                    break;
                }
            }
            return isUpper;
        }
    }
}
