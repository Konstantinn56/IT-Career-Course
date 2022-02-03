using StackDemo;
using System;

namespace UndoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedStack<string> pages = new LinkedStack<string>();

            string command = Console.ReadLine();

            while (!command.Equals("exit"))
            {
                if (command.Equals("back"))
                {
                    if (pages.Count > 1)
                    {
                        pages.Pop();
                        Console.WriteLine(pages.Peek());
                    }
                }
                else
                {
                    pages.Push(command);
                }
                command = Console.ReadLine();
            }
        }
    }
}
