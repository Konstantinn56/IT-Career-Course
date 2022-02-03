using StackDemo;
using System;

namespace CorrespondingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> indexes = new CustomStack<int>();

            string expression = "1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5";

            for (int i = 0; i < expression.Length; i++)
            {
                if(expression[i]== '(')
                {
                    indexes.Push(i);
                }
                else if(expression[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    string result = expression.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
