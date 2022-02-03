using System;

namespace DynamicListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList<int> list = new DynamicList<int>();

            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            //int index = list.IndexOf(6);
            //int removedIndex = list.Remove(8);
            //int removedItem = list.RemoveAt(1);
            //Console.WriteLine(removedItem);
            //Console.WriteLine();
            list[2] = 10;
            Console.WriteLine(list[2]);
        }
    }
}
