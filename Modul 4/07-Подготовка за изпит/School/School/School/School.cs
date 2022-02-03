using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class School
    {
        private string name;
        private List<Student> students;

        public School(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Student> Students
        {
            get { return students; }
            private set { students = value; }
        }

        ///////////////////////////////////////////////////////////////////
        public void AddStudent(string name, double grade)
        {
            Student student = new Student(name, grade);
            this.students.Add(student);
        }

        public List<Student> SortAscendingByName()
        {
            this.Students = this.Students.OrderBy(n => n.Name).ToList();
            return this.Students;
        }
        public List<Student> SortDescendingByGrade()
        {
            this.Students = this.Students.OrderByDescending(g => g.Grade).ToList();
            return this.Students;
        }

        public bool CheckStudentIsInSchool(string name)
        {
            bool result = false;
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].Name.Equals(name))
                {
                    return result = true;
                }
            }
            return result;
        }
        public string[] ProvideInformationAboutAllStudents()
        {
            string[] result = new string[this.Students.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = this.Students[i].ToString();
            }
            return result;
        }

        public List<string> RemoveStudentsByGrade(double grade)
        {
            List<string> removedStudents = new List<string>();
            for (int i = 0; i < this.Students.Count; i++)
            {
                double currentGrade = this.Students[i].Grade;
                if (currentGrade <= grade)
                {
                    removedStudents.Add(this.Students[i].Name);
                    this.Students.RemoveAt(i);
                }
            }
            return removedStudents;
        }

        public double AverageResultInRange(int start, int end)
        {
            double average = 0;
            int counter = 0;
            if (start < 0 || end > this.Students.Count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for (int i = start; i < end + 1; i++)
                {
                    average += this.Students[i].Grade;
                    counter++;
                }
            }
            average /= counter;
            return average;
            
        }
    }
}
