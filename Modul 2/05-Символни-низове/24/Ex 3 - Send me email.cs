using System;
using System.Text;

namespace ghjk
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder eMail = new StringBuilder(Console.ReadLine());
            //maria@abv.bg
            int middleSymbolIndex = GetIndexFromMiddleSymbol(eMail.ToString());//5

            int beforeSymbolSum = 0;
            int afterSymbolSum = 0;
            for (int i = 0; i < middleSymbolIndex; i++)
            {
                beforeSymbolSum += eMail[i];
            }
            for (int i = middleSymbolIndex + 1; i < eMail.Length; i++)
            {
                afterSymbolSum += eMail[i];
            }
            int diff = beforeSymbolSum - afterSymbolSum;
            if(diff >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }

        }
        static int GetIndexFromMiddleSymbol(string eMail)
        {
            int index = 0;
            for (int i = 0; i < eMail.Length; i++)
            {
                if (eMail[i].ToString().Equals("@"))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
