using System;

namespace _02._7
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> que = new LinkedQueue<int>();

            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Dequeue();
        }
    }
}
