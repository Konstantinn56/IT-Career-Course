using System;

namespace _02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                int numerator = int.Parse(Console.ReadLine());
                int denumerator = int.Parse(Console.ReadLine());
                RacionalNumber num = null;
                try
                {
                    num = new RacionalNumber(numerator, denumerator);
                    Console.WriteLine(num);
                }
                catch (InvalidOperationException ex)
                {
                    i--;
                    Console.WriteLine(ex.Message);
                }
                

            }
        }
    }
}
