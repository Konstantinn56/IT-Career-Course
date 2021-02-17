using System;

namespace Ex_8___Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            double MaterialPrice1 = double.Parse(Console.ReadLine());
            double MaterialPrice2 = double.Parse(Console.ReadLine());
            double Price = 0;
            if(MaterialPrice1 >= sbyte.MinValue && MaterialPrice1 <= sbyte.MaxValue)
            {
                //MaterialPrice1 = sbyte
                //MaterialPrice2 = int
                Price = 4 * MaterialPrice1 + 10 * MaterialPrice2;
            }
            else
            {
                //MaterialPrice1 = int
                //MaterialPrice2 = sbyte
                Price = 4 * MaterialPrice2 + 10 * MaterialPrice1;
            }
            Console.WriteLine(Price);

        }
    }
}
