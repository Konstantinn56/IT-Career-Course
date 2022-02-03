using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._8._1
{
    class Citizen : ICitizen
    {
        public Citizen(string name , int age , string id) : base(name ,age ,id)
        {
        }
    }
}
