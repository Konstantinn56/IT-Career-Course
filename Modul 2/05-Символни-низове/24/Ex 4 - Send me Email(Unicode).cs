using System;
using System.Text;

namespace dfghh
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder eMail = new StringBuilder(Console.ReadLine());
            //maria@abv.bg
            int middleSymbolIndex = GetIndexFromMiddleSymbol(eMail.ToString());//5

            string beforeSymbolSum = null;
            string afterSymbolSum = null;
            for (int i = 0; i < middleSymbolIndex; i++)
            {
                beforeSymbolSum += eMail[i];
            }
            for (int i = middleSymbolIndex + 1; i < eMail.Length; i++)
            {
                afterSymbolSum += eMail[i];
            }

            byte[] beforeSymbolBytes = Encoding.Unicode.GetBytes(beforeSymbolSum);
            byte[] afterSymbolBytes = Encoding.Unicode.GetBytes(afterSymbolSum);

            int beforeSymbolIntSum = 0;
            int afterSymbolIntSum = 0;

            foreach (var num in beforeSymbolBytes)
            {
                beforeSymbolIntSum += num;
            }
            foreach (var num in afterSymbolBytes)
            {
                afterSymbolIntSum += num;
            }

            int diff = beforeSymbolIntSum - afterSymbolIntSum;
            if (diff >= 0)
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
