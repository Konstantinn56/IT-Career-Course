using System;
using System.Collections.Generic;

namespace RemoveAddMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 3, 4, 6, 8, 9 };
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", list));

            for (int i = 0; i < list.Count-1; i++)
            {
                if(num == list[i])
                {
                    list.RemoveAt(i);
                    break;
                }
                else
                {
                    if(num > list[i] && num < list[i+1])
                    {
                        list.Insert(i + 1, num);
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));

        }
    }
}
