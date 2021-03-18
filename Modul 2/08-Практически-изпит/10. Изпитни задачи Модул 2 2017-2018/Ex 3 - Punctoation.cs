using System;
using System.Text;

namespace dfhhh
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            //abala L*ANica1203.!ze{LEee
            StringBuilder newText = new StringBuilder();
            string symbols = "!   #   %   &    (   )   *    -    .   :  ,  ?   @   [   ]   _    {   }";


            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    if (Char.IsUpper(text[i]))
                    {
                        newText.Insert(i, text[i].ToString().ToLower());
                    }
                    else
                    {
                        newText.Insert(i, text[i].ToString().ToUpper());
                    }
                }
                else if (Char.IsDigit(text[i]))
                {
                    string num = null;
                    for (int a = i; a < text.Length; a++)
                    {
                        if (Char.IsDigit(text[a]))
                        {
                            num += text[a];
                        }
                        else
                        {
                            int doubledNum = int.Parse(num) * 2;
                            newText.Insert(i, doubledNum);
                            i = a - 1;
                            break;
                        }
                    }
                }
                else if (symbols.Contains(text[i]))
                {
                    newText.Insert(i, ".");
                }
                else
                {
                    newText.Insert(i, text[i]);
                }
            }
            StringBuilder reversedText = new StringBuilder();
            int index = 0;
            for (int i = newText.Length - 1; i >= 0; i--)
            {
                reversedText.Insert(index, newText[i]);
                index++;
            }
            Console.WriteLine(reversedText);
        }
    }
}
