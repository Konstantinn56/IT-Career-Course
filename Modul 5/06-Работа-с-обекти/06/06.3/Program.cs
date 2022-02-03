using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _06._3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Type type = typeof(Person);

            MethodInfo[] methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            foreach (var item in methods)
            {
                Console.WriteLine($"{item.Name}: {item.ReturnType}");
                foreach (var p in item.GetParameters())
                {
                    Console.WriteLine(String.Join("; ", p));
                }
            }
        }
    }
}