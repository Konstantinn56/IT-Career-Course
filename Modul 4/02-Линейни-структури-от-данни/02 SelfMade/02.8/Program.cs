using System;

namespace _02._8
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedStack<int> stack = new LinkedStack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            stack.Pop();
            stack.Pop();
        }
    }
}
