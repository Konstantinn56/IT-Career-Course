using System;
using System.Linq;

namespace jkj
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            /*
              0 1 2
            0 1 2 2
            1 3 5 6
            2 8 8 9
             */
            int mainDiagonalSum = 0;
            int mainDiagonalSumEven = 0;
            int firstAndLastRowEvenSum = 0;
            int firstAndLastRowOddSum = 0;
            int secondaryDiagonalSum = 0;
            int upperMainDiagonalSum = 0;
            int lowerMainDiagonalSum = 0;
           
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if(row == col)//mainDiagonalSum
                    {
                        mainDiagonalSum += matrix[row, col];
                        if(matrix[row,col] % 2 == 0)
                        {
                            mainDiagonalSumEven += matrix[row, col];
                        }
                    }
                    else if (row < col)//upperMainDiagonalSum
                    {
                        upperMainDiagonalSum += matrix[row, col];
                    }
                    else if (row > col)//lowerMainDiagonalSum 
                    {
                        lowerMainDiagonalSum += matrix[row, col];
                    }
                    if ((row + col) == matrix.GetLength(0) - 1)//secondaryDiagonalSum
                    {
                        secondaryDiagonalSum += matrix[row, col];
                    }
                    if ((row == 0 || row == matrix.GetLength(0) - 1) && matrix[row,col] % 2 == 0)
                    {
                        firstAndLastRowEvenSum += matrix[row, col];
                    }
                    if ((col == 0 || col == matrix.GetLength(1) - 1) && matrix[row,col] % 2 != 0)
                    {
                        firstAndLastRowOddSum += matrix[row, col];
                    }

                }
            }

            double profit = 0;
            
            
            if (mainDiagonalSum == secondaryDiagonalSum && upperMainDiagonalSum % 2 == 0 && lowerMainDiagonalSum % 2 != 0)
            {
                profit = (lowerMainDiagonalSum + mainDiagonalSumEven + firstAndLastRowEvenSum + firstAndLastRowOddSum) / 4;

                Console.WriteLine("YES");
                Console.WriteLine($"The amount of money won is: {profit:f2}");
            }
            else
            {
                Console.WriteLine("NO");
            }


        }
    }
}
