using System;
using System.Linq;

namespace hkjhk
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows + 1, cols];
            
            /*
             1    2    3    5
             8    6    9    4
             5    8    4    3

             1    2    3    3
             */

            for (int row = 0; row < rows; row++)
            {
                int[] rowArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowArray[col];
                }
            }

            int[] minNums = new int[cols];
            for (int col = 0; col < cols; col++)
            {
                int minNum = int.MaxValue;
                for (int row = 0; row < rows; row++)
                {
                    if(matrix[row,col] < minNum)
                    {
                        minNum = matrix[row, col];
                    }
                }
                minNums[col] = minNum;
            }

            for (int row = rows; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = minNums[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"  {matrix[row,col]}");
                }
                Console.WriteLine();
            }

        }
    }
}
