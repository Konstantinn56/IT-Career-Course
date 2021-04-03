using System;
using System.Linq;
using System.Text;

namespace okkoko
{
    class Program
    {
        static void Main(string[] args)
        {
            string chars = "!   #   %   &    (   )   *    -    .   :  ,  ?   @   [   ]   _    {   }";
            char[] arr = chars.ToCharArray().Where(c => c != ' ').ToArray();


            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length ; i++)
            {
                if (char.IsLower(input[i]))
                {
                    result.Append(input[i].ToString().ToUpper());
                }
                else if (char.IsUpper(input[i]))
                {
                    result.Append(input[i].ToString().ToLower());
                }
                else if (char.IsDigit(input[i]))
                {
                    int num = int.Parse(input[i].ToString());
                    result.Append(num*2);
                }
                else if (arr.Contains(input[i]))
                {
                    result.Append(".");
                }
            }
            string reversedResult = new string (result.ToString().Reverse().ToArray());
            Console.WriteLine(reversedResult);
        }
    }
}
