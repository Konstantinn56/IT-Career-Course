using System;
using System.Collections.Generic;

namespace ArrayListDemo
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

            Console.WriteLine(list.RemoveAt(1));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
