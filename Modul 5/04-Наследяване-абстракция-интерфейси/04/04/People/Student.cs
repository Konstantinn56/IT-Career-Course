using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public class Student : Person
    {
        public School MySchool { get; set; }
        public Student(string name, School school) : base(name)
        {
            this.MySchool = school;
        }
        public void Study()
        {
            Console.WriteLine("Studying...");
        }
    }
}
