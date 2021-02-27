using System;
using System.Linq;

namespace asdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split();
            // 0   1   2   3    4     5    6
            //one one one two three four five
            //////////////////////////////////////////////////////////////////////
            string[] CurrentCommand = new string[3];
            while (CurrentCommand[0] != "END")
            {
                CurrentCommand = Console.ReadLine().Split();
                switch (CurrentCommand[0])
                {
                    case "Distinct":
                        string[] distinct = symbols.Distinct().ToArray();
                        symbols = distinct;
                        break;

                    case "Reverse":
                        Array.Reverse(symbols);
                        break;

                    case "Replace":
                        int PlaceHolder = int.Parse(CurrentCommand[1]);
                        if (PlaceHolder > symbols.Length || PlaceHolder < 0)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            string newText = CurrentCommand[2];
                            symbols[PlaceHolder] = newText;
                        }
                        break;
                    default:

                        break;
                }
            }
            Console.WriteLine(string.Join(", ", symbols));
        }
    }
}
