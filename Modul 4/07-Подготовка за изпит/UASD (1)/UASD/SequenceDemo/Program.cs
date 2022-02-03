using System;
using System.Collections.Generic;

namespace SequenceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int position = 1;
            int current = 0;

            queue.Enqueue(n);

            while (true)
            {
                current = queue.Peek() + 1;
                queue.Enqueue(current);
                position++;

                if(current == p)
                {
                    break;
                }

                current = queue.Peek() * 2;
                queue.Enqueue(current);
                position++;
                if (current == p)
                {
                    break;
                }
                queue.Dequeue();
            }

            Console.WriteLine(position);
        }
    }
}
