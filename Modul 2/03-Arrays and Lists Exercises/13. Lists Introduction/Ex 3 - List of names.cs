using System;
using System.Collections.Generic;
using System.Linq;

namespace sfgh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();
            //Ivan Dimitrov, Maria Ivanova, Dimitar Petrov
           
            names.Reverse();

            for (int i = 0; i < names.Count; i++)
            {
                List<string> reversedNames = names[i].Split().ToList();
                reversedNames.Reverse();
                Console.WriteLine(string.Join(" ", reversedNames));
            }
        }
    }
}
