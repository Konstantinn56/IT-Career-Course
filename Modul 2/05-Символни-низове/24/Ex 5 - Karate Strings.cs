using System;
using System.Text;

namespace sfgg
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder(Console.ReadLine());
            //abv>1>1>2>2asdasd
            int firstSymbolIndex = GetFirstSymbolIndex(str.ToString());//3
            int endPowerIndex = GetEndPowerIndex(str.ToString());//10
            
            int powersCount = GetPowersCount(str.ToString());
            int currentPowerCount = 0;
            
            int backupPower = 0;
            
            for (int i = firstSymbolIndex; i < endPowerIndex + 1; i++)
            {
                //>1>1>2>2
                if (Char.IsDigit(str[i]))
                {
                    int currentPower = 0;
                    currentPowerCount++;
                    
                    if (powersCount == currentPowerCount)
                    {
                        currentPower = backupPower + Int32.Parse(str[i].ToString());
                        str = str.Remove(i, currentPower);
                    }

                    else if ((str[i + 1].ToString()).Equals(">"))
                    {
                        backupPower = backupPower + Int32.Parse(str[i].ToString()) - 1;
                        str = str.Remove(i, 1);
                    }
                    else if((str[i + 1].ToString()) != (">"))
                    {
                        currentPower = Int32.Parse(str[i].ToString());
                        str.Remove(i, currentPower);
                    }
                    

                }
            }
            Console.WriteLine(str);


        }
        static int GetPowersCount(string str)
        {
            int powersCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    powersCount++;
                }
            }
            return powersCount;
        }
        static int GetFirstSymbolIndex(string str)
        {
            int firstSymbolIndex = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i].ToString()).Equals(">"))
                {
                    firstSymbolIndex = i;
                    break;
                }
            }
            return firstSymbolIndex;
        }
        static int GetEndPowerIndex(string str)
        {
            int endPowerIndex = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (Char.IsDigit(str[i]))
                {
                    endPowerIndex = i;
                    break;
                }
            }
            return endPowerIndex;
        }
        
        
    }
}
