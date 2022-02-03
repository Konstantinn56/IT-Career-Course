using System;

namespace _03._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> data = new Box<int>();
            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                data.Add(element);
            }
            int compare = int.Parse(Console.ReadLine());

            Console.WriteLine(data.Compare(compare));
        }
    }
}
