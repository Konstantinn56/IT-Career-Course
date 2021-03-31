using System;
using System.Linq;

namespace fff
{
    class Program
    {
        static void Main(string[] args)
        {
            int sheetCount = int.Parse(Console.ReadLine());
            double[][,] documents = new double[sheetCount+1][,];

            documents[sheetCount] = new double[sheetCount, 3];
            for (int sheet = 0; sheet < sheetCount; sheet++)
            {
                int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int rows = rowsAndCols[0];
                int cols = rowsAndCols[1];
                documents[sheet] = new double[rows, cols];
                for (int row = 0; row < rows; row++)
                {
                    int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int col = 0; col < cols; col++)
                    {
                        documents[sheet][row, col] = currentRow[col];
                    }
                }
                documents[sheetCount][sheet, 0] = GetMinNumber(documents[sheet]);
                documents[sheetCount][sheet, 1] = GetMaxNumber(documents[sheet]);
                documents[sheetCount][sheet, 2] = Math.Round(GetAverage(documents[sheet]),2);
            }

            double averageOfDocument = GetAverageOfDocument(documents[sheetCount]);
            int[] biggerThanAverageCount = new int[sheetCount];

            for (int sheet = 0; sheet < sheetCount; sheet++)
            {
                int rows = documents[sheet].GetLength(0);
                int cols = documents[sheet].GetLength(1);
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if(documents[sheet][row,col] > averageOfDocument)
                        {
                            biggerThanAverageCount[sheet]++;
                        }
                    }
                }
            }
            
            Console.WriteLine();
            PrintMinMaxAverageOfAllSheets(documents[sheetCount]);
            PrintBiggerThanAverageCount(biggerThanAverageCount);
        }
        static void PrintBiggerThanAverageCount(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
        static double GetAverageOfDocument(double[,]matrix)
        {
            double averageOfDocument = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int col = 2;
                averageOfDocument += matrix[row, col];
            }
            averageOfDocument /= matrix.GetLength(0);
            return averageOfDocument;
        }
        static void PrintMinMaxAverageOfAllSheets(double[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
        static double GetMinNumber(double[,] matrix)
        {
            double minNum = double.MaxValue;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row,col] < minNum)
                    {
                        minNum = matrix[row, col];
                    }
                }
            }
            return minNum;
        }
        static double GetMaxNumber(double[,] matrix)
        {
            double maxNum = double.MinValue;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > maxNum)
                    {
                        maxNum = matrix[row, col];
                    }
                }
            }
            return maxNum;
        }
        static double GetAverage(double[,] matrix)
        {
            double average = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    average += matrix[row, col];
                }
            }
            average = average / matrix.Length;
            return average;
        }
    }
}
