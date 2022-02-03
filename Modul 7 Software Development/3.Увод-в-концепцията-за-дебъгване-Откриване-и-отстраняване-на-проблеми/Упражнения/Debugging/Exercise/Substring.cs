using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Substring
    {
        public static void Method()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i].ToString()).Equals("p"))
                {
                    hasMatch = true;

                    int endIndex = i + jump;
                    string matchedString;
                    if (endIndex >= text.Length)
                    {
                        jump = text.Length - i;
                        matchedString = text.Substring(i, jump);
                    }
                    else
                    {
                        matchedString = text.Substring(i, jump + 1);
                    }
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
