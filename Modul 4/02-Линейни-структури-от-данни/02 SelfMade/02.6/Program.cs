using System;

namespace _02._6
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(1);
            list.AddLast(3);
            list.RemoveFirst();
            list.AddFirst(1);
            list.RemoveLast();
            list.AddLast(3);
            int[] arr = list.ToArray();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

             
            
        }
        public static void Print(int item)
        {
            Console.WriteLine(item);
        }
    }
}
