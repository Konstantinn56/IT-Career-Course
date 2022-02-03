using System;
using System.Collections.Generic;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            Console.WriteLine(string.Join(" ", s.ToArray()));
            LinkedStack<int> stack = new LinkedStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack.Pop());
            stack.Push(5);
            Console.WriteLine(string.Join(" ", stack.ToArray()));
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());

            CustomStack<int> cs = new CustomStack<int>();
            cs.Push(1);
            cs.Push(2);
            cs.Push(3);
            cs.Push(4);
            Console.WriteLine(string.Join(" ", cs.ToArray()));
        }
    }
}
