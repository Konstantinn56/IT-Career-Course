using System;
using System.Collections.Generic;
using System.Linq;

namespace asdffh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> lastGrades = new List<int>();
            foreach (var g in grades)
            {
                lastGrades.Add(g);
            }

            int examsCount = int.Parse(Console.ReadLine());
            for (int grade = 0; grade < examsCount; grade++)
            {
                int[] numAndGrade = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                int studentNum = numAndGrade[0];
                int studentGrade = numAndGrade[1];

                if (studentGrade < grades[studentNum])
                {
                    grades[studentNum] -= studentGrade;
                }

                else if(studentGrade > grades[studentNum])
                {
                    grades[studentNum] += studentGrade;
                }
                if ((grades[studentNum]) < lastGrades[studentNum]/2)
                {
                    grades.RemoveAt(studentNum); 
                }
                if(grades.Count == 0)
                {
                    Console.WriteLine("All studets has been expelled due bad results!");
                    break;
                }
            }
            Console.WriteLine(string.Join("; ",grades));
        }
    }
}
