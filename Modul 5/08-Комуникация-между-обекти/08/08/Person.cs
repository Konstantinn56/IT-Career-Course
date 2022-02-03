using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Person
    {

        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set 
            {
                this.OnPropertyChanges?.Invoke(nameof(FirstName));
                firstName = value; 
            }
        }
        public string LastName
        {
            get { return lastName; }
            set 
            {
                lastName = value; 
            }
        }

        public Action<string> OnPropertyChanges { get; set; }

    }
}
