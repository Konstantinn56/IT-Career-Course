using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._8._1.IC
{
    class Person : Human , IIdentifiable, IBirthable
    {
        
        private string id;
        private string birthdate;

        public Person(string n , int a , string id , string b) : base(n , a)
        {
            this.Name = n;
            this.Age = a;
            this.Id = id;
            this.Birthdate = b;
        }

       
        public string Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }
        public string Birthdate
        {
            get { return birthdate; }
            private set { birthdate = value; }
        }
    }
}
