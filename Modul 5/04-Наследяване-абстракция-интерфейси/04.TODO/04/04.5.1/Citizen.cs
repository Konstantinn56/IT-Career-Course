using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._5._1
{
    class Citizen : IPerson , IBirthable , IIdentifiable
    {
        public string Name { get ; set; }
        public int Age { get; set; }

        public string Birthdate { get; set; }

        public string Id { get; set; }

        public Citizen(string name, int age, string id,string b)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = b;
        }


     }
}
