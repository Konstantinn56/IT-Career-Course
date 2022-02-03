using System;
using System.Collections.Generic;
using System.Linq;

namespace _071
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string oddOrEven = Console.ReadLine();

            Predicate<int> odd = x => x % 2 != 0;
            Predicate<int> even = x => x % 2 == 0;

            List<int> result = new List<int>();
            switch (oddOrEven)
            {
                case "odd":
                    {
                        result = Print(input, odd);
                        break;
                    }
                case "even":
                    {
                        result = Print(input, even); 
                        break;s
                    }
            }
            Action<List<int>> print = x => Console.WriteLine(String.Join(", " , x));
            print(result);

        }
        public static List<int> Print(int[] input , Predicate<int> p)
        {
            List<int> result = new List<int>();
            foreach (var n in input)
            {
                if (p(n))
                {
                    result.Add(n);
                }
            }
            return result;
        }
    }

}