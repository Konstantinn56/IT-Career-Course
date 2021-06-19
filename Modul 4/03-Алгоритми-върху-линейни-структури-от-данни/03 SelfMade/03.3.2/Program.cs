using System;
using System.Collections.Generic;

namespace _03._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Queue<int> sQueue = new Queue<int>();
            int n = int.Parse(Console.ReadLine());


            int Count = 1;
            int current = 0;
            queue.Enqueue(n);
            sQueue.Enqueue(n);
            while (true)
            {
                current = sQueue.Peek() + 1;
                queue.Enqueue(current);
                sQueue.Enqueue(current);
                Count++;
                if(Count == 50)
                {
                    break;
                }

                current = 2 * sQueue.Peek() + 1;
                queue.Enqueue(current);
                sQueue.Enqueue(current);
                Count++;
                if (Count == 50)
                {
                    break;
                }

                current = sQueue.Peek() + 2;
                queue.Enqueue(current);
                sQueue.Enqueue(current);
                Count++;
                if (Count == 50)
                {
                    break;
                }

                sQueue.Dequeue();
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{queue.Dequeue()}, ");
            }
        }
    }
}
