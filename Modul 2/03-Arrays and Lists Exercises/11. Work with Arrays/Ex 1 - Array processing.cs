using System;
using System.Linq;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split();
            // 0   1   2   3    4     5    6
            //one one one two three four five
            int rows = int.Parse(Console.ReadLine());
            //////////////////////////////////////////////////////////////////////
            for (int Command = 0; Command < rows; Command++)
            {
                string[] CurrentCommand = Console.ReadLine().Split();
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
                        string newText = CurrentCommand[2];
                        symbols[PlaceHolder] = newText;
                        break;
                    default:
                        break;
                }
               
            }
            Console.WriteLine(string.Join(", ", symbols));
        }
    }
}
