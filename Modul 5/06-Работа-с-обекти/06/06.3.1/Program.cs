using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._3._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.StealFieldInfo("_06._3._1.Hacker", "username", "password");
            Console.WriteLine(result);
        }
    }
}