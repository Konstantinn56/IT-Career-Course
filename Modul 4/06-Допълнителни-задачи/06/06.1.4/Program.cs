using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Stack<int> source = new Stack<int>(Enumerable.Range(1, n).Reverse());
            Stack<int> destination = new Stack<int>();
            Stack<int> spare = new Stack<int>();

            MoveDisks(n, source, destination, spare);
        }
        public static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if(bottomDisk == 1)
            {
                destination.Push(source.Pop());
                Print(source, destination, spare);
            }
            else
            {
                MoveDisks(bottomDisk - 1,source,spare,destination);
                Print(source, destination, spare);
                    
                destination.Push(source.Pop());
                Print(source, destination, spare);

                MoveDisks(bottomDisk - 1, spare, destination, source);
                Print(source, destination, spare);
            }
        }
        public static void Print(Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            Console.WriteLine($"Source: {string.Join(" ", source.Reverse())}");
            Console.WriteLine($"Destination: {string.Join(" ", destination.Reverse())}");
            Console.WriteLine($"Spare: {string.Join(" ", spare.Reverse())}");
            Console.WriteLine();
        }
    }
}
