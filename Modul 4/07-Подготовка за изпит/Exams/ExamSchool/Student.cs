using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSchool
{
    public class Student
    {
        private string name;
        private double grade;
        private List<double> grades;

        public Student()
        {
            this.grades = new List<double>();
        }
        public Student(string name, double grade) : this()
        {
            this.Name = name;
            this.Grade = grade;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public double Grade
        {
            get { return this.grade; }
            private set { this.grade = value; }
        }
        public List<double> Grades
        {
            get { return grades; }
        }

        public override string ToString()
        {
            return $"Student {this.Name} has {this.Grade:f2}.";
        }
    }
}
