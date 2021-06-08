using System;

namespace _02._2_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            list.RemoveAt(2);
            Console.WriteLine(list.Contains(3)); 
        }
    }
}
