using System;

namespace dgbb
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string uniStr = UniStrConverter(str.Length , str);
            Console.WriteLine(uniStr);
            
        }
        static string UniStrConverter(int strLength,string str)
        {
            string uniStr = null;
            for (int i = 0; i < strLength; i++)
            {
                uniStr += String.Format("\\u{0:x4}" , (int)str[i]);
            }
            return uniStr;
        }
    }
}
