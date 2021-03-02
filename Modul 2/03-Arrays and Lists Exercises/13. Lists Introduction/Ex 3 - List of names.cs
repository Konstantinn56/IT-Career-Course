using System;
using System.Collections.Generic;
using System.Linq;

namespace sfgh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            //Ivan Maria Dimitar Simona Petya
            names.Reverse();
            Console.WriteLine(string.Join("; ",names));

        }
    }
}
