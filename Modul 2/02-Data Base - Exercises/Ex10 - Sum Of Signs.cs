using System;

namespace Ex_10___Sum_Of_Signs
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int Sum = 0;

            for (int i = 0; i < rows; i++)
            {
                char Symbol = char.Parse(Console.ReadLine());
                Sum += Convert.ToInt32(Symbol);
            }
            Console.WriteLine($"The sum equals: {Sum}");
        }
    }
}
