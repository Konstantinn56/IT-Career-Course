using System;
using System.Collections.Generic;
using System.Linq;

namespace fsbn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> List = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //1 2 3 4 5 6
            //5 2 3

            int countTake = arr[0];
            int countDelete = arr[1];
            int Number = arr[2];

            List<int> newList = List.Take(countTake).Skip(countDelete).ToList();

            Console.WriteLine(newList.Contains(Number) ? "YES!" : "NO!");

            //if (newList.Contains(Number))
            //{
            //    Console.WriteLine("YES!");
            //}
            //else
            //{
            //    Console.WriteLine("NO!");
            //}
        }
    }
}
