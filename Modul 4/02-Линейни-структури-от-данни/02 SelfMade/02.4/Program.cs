using System;

namespace _02._4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            int[] arr = stack.ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
