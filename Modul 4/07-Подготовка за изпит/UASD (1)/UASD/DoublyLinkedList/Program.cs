using System;
using System.Collections.Generic;
using System.Linq;

namespace DoublyLinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();

            list.AddFirst("Ivan");
            list.AddFirst("Pesho");
            //Console.WriteLine(list.RemoveFirst());
            //Console.WriteLine(list.RemoveLast());
            list.AddLast("Gosho");
            Console.WriteLine();
            string ivan = list.Where(n => n == "Ivan").FirstOrDefault();
            List<string> sorted = list.OrderBy(n => n).ToList();
            //list.ForEach(Print);
            //list.ForEach(delegate (string item)
            //{
            //    Console.WriteLine(item);
            //});
            list.ForEach(item => Console.WriteLine(item));
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(string.Join("; ", list.ToArray()));
        }

        public static void Print(string item)
        {
            Console.WriteLine(item);
        }
    }
}
