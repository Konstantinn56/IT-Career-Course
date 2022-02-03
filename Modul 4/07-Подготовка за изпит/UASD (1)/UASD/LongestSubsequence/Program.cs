using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            LongestSubsetEqualsNumbers(list);
           
        }

        public static void LongestSubsetEqualsNumbers(List<int> list)
        {
            //10 9 2 3 6 5 5 4 3 2
            int currentValue = list[0];
            List<int> maxSubSequence = new List<int>();
            List<int> tempSubSequence = new List<int>();
            tempSubSequence.Add(currentValue);

            for (int i = 1; i < list.Count; i++)
            {
                if (currentValue == list[i])
                {
                    tempSubSequence.Add(list[i]);
                    //currentValue = list[i];
                    if (tempSubSequence.Count >= maxSubSequence.Count)
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
        public static void LongestDecreasingSubset(List<int> list)
        {
            //10 9 2 3 6 5 5 4 3 2
            int currentValue = list[0];
            List<int> maxSubSequence = new List<int>();
            List<int> tempSubSequence = new List<int>();
            tempSubSequence.Add(currentValue);

            for (int i = 1; i < list.Count; i++)
            {
                if (currentValue >= list[i])
                {
                    tempSubSequence.Add(list[i]);
                    //currentValue = list[i];
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
            //1 1 3 4 5 2 3 6 7
            int currentValue = list[0];
            List<int> maxSubSequence = new List<int>();
            List<int> tempSubSequence = new List<int>();
            tempSubSequence.Add(currentValue);

            for (int i = 1; i < list.Count; i++)
            {
                if(currentValue < list[i])
                {
                    tempSubSequence.Add(list[i]);
                    //currentValue = list[i];
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

        public static void LongestSubsequenceEqualsNumbers(List<int> list)
        {
            //12 2 7 4 3 3 3 8 8
            int current = list[0];//12
            int counter = 1;
            int maxCounter = 1;
            int maxValue = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (current == list[i])
                {
                    counter++;
                    if (counter >= maxCounter)
                    {
                        maxCounter = counter;
                        maxValue = current;
                    }
                }
                else
                {
                    current = list[i];
                    counter = 1;
                }
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(maxValue + " ");
            }
        }
    }
}
