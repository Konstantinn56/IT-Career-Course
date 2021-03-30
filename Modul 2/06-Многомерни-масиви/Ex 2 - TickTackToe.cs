using System;
using System.Linq;

namespace fdfg
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[3, 3];
            int size = 3;
            for (int row = 0; row < size; row++)
            {
                char[] currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            /*
                X - O
                - X O
                - - X
            */

            bool hasAWinner = false;
            for (int row = 0; row < size; row++)
            {
                int col = 0;
                if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row, col + 2] && matrix[row,col].ToString() != "-")
                {
                    hasAWinner = true;
                    PrintTheWinner(matrix[row, col]);
                }
                
            }
            for (int col = 0; col < size; col++)
            {
                int row = 0;
                if (matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 2, col] && matrix[row, col].ToString() != "-")
                {
                    hasAWinner = true;
                    PrintTheWinner(matrix[row, col]);
                }
            }

            int dRow = 0;
            int dCol = 0;
            if(matrix[dRow ,dCol] == matrix[dRow + 1, dCol + 1] && matrix[dRow, dCol] == matrix[dRow + 2, dCol + 2] && matrix[dRow,dCol].ToString() != "-")
            {
                hasAWinner = true;
                PrintTheWinner(matrix[dRow, dCol]);
            }
            if(matrix[dRow, dCol + 2] == matrix[dRow + 1, dCol + 1] && matrix[dRow, dCol + 2] == matrix[dRow + 2, dCol] && matrix[dRow, dCol + 2].ToString() != "-")
            {
                hasAWinner = true;
                PrintTheWinner(matrix[dRow, dCol + 2]);
            }

            if (!hasAWinner)
            {
                Console.WriteLine("There is no winner");
            }
        }
        static void PrintTheWinner(char winner)
        {
            Console.WriteLine($"The winner is: {winner}");
        }
    }
}
