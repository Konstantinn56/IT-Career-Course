using System;
using System.Collections.Generic;

namespace _03._1
{
    class Program
    {
        public static List<T> CreateList<T>(T item, int count)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < count; i++)
            {
                list.Add(item);
            }
            return list;
        }
        static void Main(string[] args)
        {
            List<int> list = CreateList<int>(5, 10);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
