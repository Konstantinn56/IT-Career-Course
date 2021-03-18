using System;
using System.Collections.Generic;
using System.Linq;

namespace fdghh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = Console.ReadLine().Split().Select(int.Parse).ToList();
            //10 20 30
            int tests = int.Parse(Console.ReadLine());
            //2
            int deletedGradesCount = 0;
            for (int test = 0; test < tests; test++)
            {
                
                int[] numAndGrade = Console.ReadLine().Split().Select(int.Parse).ToArray();
                //0 5
                int index = numAndGrade[0];
                int lastGrade = grades[index];
                if (numAndGrade[1] < lastGrade)//5
                {
                    grades[index] = grades[index] - numAndGrade[1];
                }
                else if(numAndGrade[1] > lastGrade)
                {
                    grades[index] = lastGrade + numAndGrade[1];
                }
                if(grades[index] < lastGrade / 2)
                {
                    grades.RemoveAt(index);
                    deletedGradesCount++;
                }
                if (deletedGradesCount >= grades.Count)
                {
                    Console.WriteLine("All studets has been expelled due bad results!");
                    break;
                }
            }
            if(deletedGradesCount < grades.Count)
            {
                Console.WriteLine(string.Join("; ",grades));
            }
        }
    }
}
