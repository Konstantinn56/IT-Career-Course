using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._8._1.IC
{
    class Pet : IBirthable
    {
        public Pet(string n , string b)
        {
            this.Name = n;
            this.Birthdate = b;
        }
        public string Name { get; private set; }

        public string Birthdate { get; private set; }
    }
}
