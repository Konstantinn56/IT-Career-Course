using System;
using System.Linq;

namespace aaa
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(". , : ; ( ) [ ] \" ' \\ / ! ?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLower())
                .Where(w => w.Length < 5)
                .Distinct()
                .OrderBy(w => w)
                .ToArray();

            Console.WriteLine(string.Join(", ",words));
        }
    }
}
