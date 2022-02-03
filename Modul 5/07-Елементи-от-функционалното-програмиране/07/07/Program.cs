using System;
using System.Collections.Generic;
using System.Linq;

namespace _07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string[]> print = item =>
            {
                foreach (string i in item)
                {
                    Console.WriteLine(i);
                }
            };
            print(input);
        }
    }
}