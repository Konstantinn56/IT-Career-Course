using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._1._6
{
    class Program
    {
        private static int height = int.Parse(Console.ReadLine());
        private static int width = int.Parse(Console.ReadLine());
        private static string[] matrix = new string[height];
        private static List<Region> regions = new List<Region>();
        private static int area = 0;
        static void Main(string[] args)
        {
            DrawMatrix();
            int row,col,counter = 0;
            while (FindStartingCell())
            {
                area = 0;
                row = regions[counter].Y;
                col = regions[counter].X;
                FindPath(row,col, 'o');
                regions[counter].Area = area;
                counter++;
            }
            Console.WriteLine($"Areas found: {regions.Count}");
            regions = regions.OrderByDescending(a => a.Area).ToList();
            for (int i = 0; i < regions.Count; i++)
            {
                Console.WriteLine($"Area #{i + 1} at ({regions[i].X},{regions[i].Y}), Size: {regions[i].Area}");
            }
        }
        public static void FindPath(int row , int col, char direction)
        {
            if (!IsInBounds(row, col))
            {
                return;
            }
            else if(!IsVisited(row,col))
            {
                Mark(row, col, direction);
                FindPath(row, col + 1, 'R');
                FindPath(row+ 1, col, 'D');
                FindPath(row, col - 1, 'L');
                FindPath(row - 1, col, 'U');
            }
        }
        public static bool IsInBounds(int row, int col)
        {
            if(row < 0 || col >= width || col < 0 || row >= height)
            {
                return false;
            }
            return true;
        }
        public static void Mark(int row,int col,char direction)
        {
            var copy = matrix[row].ToCharArray();
            copy[col] = direction;
            matrix[row] = string.Join("*", copy);
            area++;
        }
        public static bool IsVisited(int row,int col)
        {
            if (matrix[row][col] == 'v')
            {
                return true;
            }
            return false;
        }
        public static bool FindStartingCell()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if(matrix[i][j] == '-')
                    {
                        regions.Add(new Region(i,j,0));
                        return true;
                    }

                }
            }
            return false;
        }
        public static void DrawMatrix()
        {
            for (int i = 0; i < height; i++)
            {
                matrix[i] = Console.ReadLine();
            }
        }
    }
    public class Region
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Area { get; set; }

        public Region(int x , int y, int area = 0)
        {
            this.X = x;
            this.Y = y;
            this.Area = area;
        }
    }
}
