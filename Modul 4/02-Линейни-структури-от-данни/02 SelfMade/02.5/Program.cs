using System;
using System.Collections.Generic;

namespace _02._5
{
    class Program
    {
        static void Main(string[] args)
        {
            ReversedList<int> list = new ReversedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            list.RemoveAt(2);
            list.RemoveAt(2);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
