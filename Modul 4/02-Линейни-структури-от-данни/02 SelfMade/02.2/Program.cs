using System;

namespace _02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            CusomArrayList<int> list = new CusomArrayList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Insert(5, 6);
            Console.WriteLine(list.IndexOf(6));
            list.Clear();
            Console.WriteLine(list.Contains(1));
            list.Add(1);
            list.Add(2);
            list.Remove(0);
            list.Add(2);
            list.Remove(2);
        }
    }
}
