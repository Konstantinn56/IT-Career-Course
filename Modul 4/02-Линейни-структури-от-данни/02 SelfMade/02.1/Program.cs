using System;
using System.Collections.Generic;

namespace _02._1
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList<int> list = new ArrayList<int>();
            list.Add(5);
            list[0] = list[0] + 1;
            int element = list.RemoveAt(0);
        }
    }
}
