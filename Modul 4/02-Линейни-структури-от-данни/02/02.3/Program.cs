using System;
using System.Collections.Generic;

namespace _02._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Queue<int> que = new Queue<int>();
            que.Enqueue(5);
            que.Enqueue(6);
            que.Enqueue(7);
            que.Enqueue(8);
            que.Enqueue(9);
            que.Dequeue();
            que.Peek();
            int[] arr = que.ToArray();
            */

            CircularQueue<int> que = new CircularQueue<int>();

            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);
            Console.WriteLine(que.Peek());
            while(que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
            Console.WriteLine(que.Count);

        }
    }
}
