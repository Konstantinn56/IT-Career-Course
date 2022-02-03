using System;
using System.Collections.Generic;
using System.Linq;

namespace _716
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divider = int.Parse(Console.ReadLine());

            Predicate<int> check = n => n % divider == 0;

            Func<List<int>, List<int>> func = list =>
           {
               for (int i = 0; i < list.Count; i++)
               {
                   if (check(list[i]))
                   {
                       list.RemoveAt(i);
                   }
               }
               return list;
           };

            Console.WriteLine(());
        }
    }
}