using System;

namespace Ex_11___Stitching_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char Divider = char.Parse(Console.ReadLine());
            string EvenOrOdd = Console.ReadLine();//even(cheten) , odd(necheten)
            int rows = int.Parse(Console.ReadLine());
            string TheString = "";

            for (int i = 1; i <= rows; i++)
            {
                string NewWord = Console.ReadLine();
                if (EvenOrOdd.Equals("even"))
                {
                    if(i % 2 == 0)
                    {
                        TheString += NewWord;
                        TheString += Divider;
                    }
                }
                else if (EvenOrOdd.Equals("odd"))
                {
                    if(i % 2 != 0)
                    {
                        TheString += NewWord;
                        TheString += Divider;
                    }
                }
            }
           
            Console.WriteLine(TheString);

        }
    }
}
