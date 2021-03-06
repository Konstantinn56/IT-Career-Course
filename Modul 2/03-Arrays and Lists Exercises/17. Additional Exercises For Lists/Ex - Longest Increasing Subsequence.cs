using System;
using System.Collections.Generic;
using System.Linq;

namespace joik
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] length = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;
            for (int i = 0; i < sequence.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;
                //3 14 5 12 15 7 8 9 11 10 1
                //0  1 2  3  4 5 6 7  8  9 10
                for (int j = 0; j < i; j++)
                {
                    if(sequence[j] < sequence[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }
                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }
            /////////////////////////////////////////
            List<int> longestSequence = new List<int>();

            for (int i = 0; i < maxLength; i++)
            {
                longestSequence.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];           
            }
            longestSequence.Reverse();
            Console.WriteLine(string.Join(" ",longestSequence));
        }
    }
}
