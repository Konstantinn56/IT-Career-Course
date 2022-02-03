using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._8._1
{
    abstract class ICitizen : People
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public ICitizen(string name , int age , string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
    }
}
