using System;

namespace sdfgfsg
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();
            //alyakeykala kalakey
            //key

            while (text.Contains(pattern) && pattern != (""))
            {
                int lastPaternIndex = text.LastIndexOf(pattern);
                text = text.Remove(lastPaternIndex, pattern.Length);

                pattern = pattern.Remove(pattern.Length / 2, 1);
                if (pattern.Length > 1)
                {
                    string reversedPattern = null;
                    for (int i = pattern.Length - 1; i >= 0; i--)
                    {
                        reversedPattern += pattern[i];
                    }
                    pattern = reversedPattern;
                }
            }
            Console.WriteLine(text);
        }
    }
}
