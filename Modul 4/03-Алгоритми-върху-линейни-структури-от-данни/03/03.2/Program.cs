using System;
using System.Collections.Generic;

namespace _03._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int>() { 2, 4, 6 };

            Console.WriteLine(string.Join(", ", Union(list1, list2)));
        }
        public static List<int> Interesect(List<int> list1, List<int> list2)
        {
            List<int> interesect = new List<int>();
            foreach (var item in list1)
            {
                if (list2.Contains(item))
                {
                    interesect.Add(item);
                }
            }
            return interesect;
        }

        public static List<int> Union(List<int> list1, List<int> list2)
        {
            List<int> union = new List<int>();
            union.AddRange(list1);

            foreach (var item in list2)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }
            return union;
        }
    }
}
