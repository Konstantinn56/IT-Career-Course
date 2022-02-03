using System;
using System.Collections.Generic;
using System.Linq;

namespace _08
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Ivan";
            person.LastName = "Ivanov";

            

            person.OnPropertyChanges += property =>
            {
                Console.WriteLine($"{property} has been changed!");
            };
            person.FirstName = "Dragan";

        }
        
        
    }
}