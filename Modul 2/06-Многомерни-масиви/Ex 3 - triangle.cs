using System;

namespace adsff
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            /*
                       1
                     1   1
                   1   2   1
                 1   3   3   1
            */
            long[][] triangle = new long[h][];

            for (int row = 0; row < h; row++)
            {
                triangle[row] = new long[row + 1];
            }

            

            triangle[0][0] = 1; 
            for (int row = 0; row < h - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            for (int row = 0; row < h; row++)
            {
                Console.Write("".PadLeft((h - row) *2));
                for (int col = 0; col <=row; col++)
                {
                    Console.Write($"{triangle[row][col]}   ");
                }
                Console.WriteLine();
            }
        }
    }
}
