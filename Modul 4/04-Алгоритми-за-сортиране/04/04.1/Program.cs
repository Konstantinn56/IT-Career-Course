using System;
using System.Linq;

namespace _04._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Sorting.InsertionSort(height);
            Console.WriteLine(string.Join(" ", height));

            
        }

       
        
    }
}
