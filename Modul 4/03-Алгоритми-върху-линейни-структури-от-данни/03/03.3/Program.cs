using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();



        }
        public static void LongestDecreasingSubset(List<int> list)
        {
            //10 9 2 3 6 5 4 3 2
            int currentValue = list[0];
            List<int> maxSubSequence = new List<int>();
            List<int> tempSubSequence = new List<int>();
            tempSubSequence.Add(currentValue);


            for (int i = 1; i < list.Count; i++)
            {
                if (currentValue > list[i])
                {
                    tempSubSequence.Add(list[i]);
                    if (tempSubSequence.Count > maxSubSequence.Count)
                    {
                        maxSubSequence.Clear();
                        maxSubSequence.AddRange(tempSubSequence);
                    }
                }
                else
                {
                    tempSubSequence.Clear();
                    tempSubSequence.Add(list[i]);
                }
                currentValue = list[i];
            }
            Console.WriteLine(string.Join(", ", maxSubSequence));
        }
        public static void LongestGrowingSubset(List<int> list)
        {
            //1 2 3 4 2 3 6 7
            int currentValue = list[0];
            List<int> maxSubSequence = new List<int>();
            List<int> tempSubSequence = new List<int>();
            tempSubSequence.Add(currentValue);


            for (int i = 1; i < list.Count; i++)
            {
                if(currentValue <= list[i])
                {
                    tempSubSequence.Add(list[i]);
                    if(tempSubSequence.Count > maxSubSequence.Count)
                    {
                        maxSubSequence.Clear();
                        maxSubSequence.AddRange(tempSubSequence);
                    }
                }
                else
                {
                    tempSubSequence.Clear();
                    tempSubSequence.Add(list[i]);
                }
                currentValue = list[i];
            }
            Console.WriteLine(string.Join(", ", maxSubSequence));
        }
    }
}
