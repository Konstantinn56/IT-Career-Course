using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            Student student = new Student();

            school.Add(student);

        }
    }
}
