using System;
using System.Collections;
using System.Collections.Generic;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList strings = new ArrayList();
            strings.Add("1");
            strings.Add("2");
            strings.Add(3); // OК ли е?!

            foreach (var item in strings)
            {
                if (item is int)
                {
                    Console.WriteLine((int)item + 2);
                }
                else
                {
                    Console.WriteLine(item.GetType().Name);
                }
            }

            String e1 = (string)strings[0];
            String e2 = (string)strings[1];
            String e3 = (String)strings[2]; // RTE
            
            //////////////////////////////////////////////////////////////////////////////////////////
            
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            //nums.Add("3");
        }
    }
}
