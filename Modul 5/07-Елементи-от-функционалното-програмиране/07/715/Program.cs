using System;
using System.Collections.Generic;
using System.Linq;

namespace _715
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            Func<int[], int[]> add = n => { return n.Select(x => x + 1).ToArray(); };
            Func<int[], int[]> multiply = n => {return n.Select(x => x * 2).ToArray();};
            Func<int[],int[]> substract = n => { return n.Select(x => x - 1).ToArray(); };
            Action<int[]> print = n => Console.WriteLine(String.Join(" ", n));
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        {
                            numbers = add(numbers);
                            break;
                        }
                    case "multyply":
                        {
                            numbers = multiply(numbers);
                            break;
                        }
                    case "substract":
                        {
                            numbers = substract(numbers);
                            break;
                        }
                    case "print":
                        {
                            print(numbers);
                            break;
                        }
                }
            }
        }
    }
}