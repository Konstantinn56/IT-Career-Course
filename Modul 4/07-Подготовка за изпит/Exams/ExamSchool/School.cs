using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamSchool
{
    public class School
    {
        private string name;
        private List<Student> students;

        public School()
        {
            this.students = new List<Student>();
        }
        public School(string name) : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Student> Students
        {
            get { return students; }
        }

        public void AddStudent(string name, double grade)
        {
            Student student = new Student(name, grade);
            this.students.Add(student);
        }
        public string[] ProvideInformationAboutAllStudents()
        {
            string[] allStudents = new string[this.Students.Count];
            for (int i = 0; i < this.Students.Count; i++)
            {
                allStudents[i] = this.Students[i].ToString();
            }
            return allStudents;
        }

        public List<Student> SortAscendingByName()
        {
            return this.students = this.students
                .OrderBy(s => s.Name)
                .ToList();
        }

        public List<Student> SortDescendingByGrade()
        {
            return this.students = this.students
                .OrderByDescending(s => s.Grade)
                .ToList();
        }

        public bool CheckStudentIsInSchool(string name)
        {
            return this.students.Where(s => s.Name == name).SingleOrDefault() != null
        }

        public List<string> RemoveStudentsByGrade(double grade)
        {
            List<string> removed = this.students.Where(s => s.Grade == grade).Select(s => s.Name).ToList();

            for (int i = 0; i < this.students.Count; i++)
            {
                if(this.students[i].Grade < grade)
                {
                    this.students.RemoveAt(i);
                }
            }
            return removed;
        }

        internal double AverageResultInRange(int start, int end)
        {
            double sum = 0;
            int count = 0;
            for (int i = start; i < end; i++)
            {
                sum += this.students[i].Grade;
                count++;
            }
            return sum / count;//count == (end - start);
        }
    }
}
