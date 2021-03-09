using System;

namespace pll
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            //int , char , string

            if (valueType.Equals("int"))
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int result = GetMaxInt(num1, num2);
                Console.WriteLine(result);
            }
            else if (valueType.Equals("char"))
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                char result = GetMaxChar(char1, char2);
                Console.WriteLine(result);
            }
            else if (valueType.Equals("string"))
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();
                string result = GetMaxString(text1, text2);
                Console.WriteLine(result);
            }
        }
        static int GetMaxInt(int num1, int num2)
        {
            int biggerNum = 0;
            if (num1 >= num2)
            {
                biggerNum = num1;
            }
            else
            {
                biggerNum = num2;
            }
            return biggerNum;
        }
        static char GetMaxChar(char char1 , char char2)
        {
            char biggerChar = ' ';
            if(char1 >= char2)
            {
                biggerChar = char1;
            }
            else
            {
                biggerChar = char2;
            }
            return biggerChar;
        }
        static string GetMaxString(string text1 , string text2)
        {
            string biggerText = null;
            if(text1.CompareTo(text2) >= 0)
            {
                biggerText = text1;
            }
            else
            {
                biggerText = text2;
            }
            return biggerText;
        }

    }
}
