using System;
using System.Collections.Generic;

namespace asdff
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double[,] matrix = new double[rows, cols + 1];

            for (int row = 0; row < rows; row++)
            {
                double average = 0;
                int averagePosition = matrix.GetLength(1) - 1;
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                    average += matrix[row, col];
                }
                average = average / cols;
                matrix[row, averagePosition] = average;
            }
            PrintMatrix(matrix);
        }
        static void PrintMatrix(double[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    Console.Write($"         {matrix[row,col]}");
                }
                Console.Write($"      {matrix[row,matrix.GetLength(1) - 1]}");
                Console.WriteLine();
            }
        }
    }
}
