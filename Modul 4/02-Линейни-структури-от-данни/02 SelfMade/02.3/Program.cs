using System;

namespace _02._3
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue<int> idk = new CircularQueue<int>();
            idk.Enqueue(1);
            idk.Enqueue(2);
            idk.Enqueue(3);
            idk.Enqueue(4);
            idk.Enqueue(5);
        }
    }
}
