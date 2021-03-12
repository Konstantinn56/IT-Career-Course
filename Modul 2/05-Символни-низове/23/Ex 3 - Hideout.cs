using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agadfg
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int startIndexOfHideout = 0;
            int endIndexofHideout = 0;
            int maxCount = 0;

            while (maxCount == 0)
            {
                string[] symbolsAndLength = Console.ReadLine().Split();
                char symbol = char.Parse(symbolsAndLength[0]);//@
                int length = int.Parse(symbolsAndLength[1]);//5
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i].Equals(symbol))
                    {
                        int counter = 0;
                        for (int a = i; a < text.Length; a++)
                        {
                            if (text[a].Equals(symbol))
                            {
                                counter++;
                            }
                            else
                            {
                                endIndexofHideout = a - 1;
                                break;
                            }
                            if (counter >= length)
                            {
                                startIndexOfHideout = i;
                                maxCount = counter;
                            }
                        }
                    }
                    if (maxCount >= length)
                    {
                        break;
                    }
                }
            }
            int hideoutSize = endIndexofHideout - startIndexOfHideout + 1;
            Console.WriteLine($"Hideout found at index {startIndexOfHideout} and it is with size {hideoutSize}!");
        }
    }
}
