using System;
using System.Collections.Generic;

namespace _04._8._1.IC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commandLine = Console.ReadLine().Split();
            List<IBirthable> comunity = new List<IBirthable>();

            while (!commandLine[0].Equals("End"))
            {
                if(commandLine[0].Equals("Robot"))
                {
                    //Robot
                    //IIdentifiable robot = new Robot(commandLine[0] , commandLine[1]);
                    //comunity.Add(robot);
                }
                else if (commandLine[0].Equals("Citizen")) 
                {
                    //Person
                    IBirthable person = new Person(commandLine[1], int.Parse(commandLine[2]), commandLine[3] , commandLine[4]);
                    comunity.Add(person);
                }
                else if (commandLine[0].Equals("Pet"))
                {
                    IBirthable Pet = new Pet(commandLine[1] , commandLine[2]);
                }
                commandLine = Console.ReadLine().Split();
            }
            string fakeId = Console.ReadLine();

            foreach (var c in comunity)
            {
                if (c.Birthdate.EndsWith(fakeId))
                {
                    Console.WriteLine(c.Birthdate);
                }
            }
            
        }
    }
}
