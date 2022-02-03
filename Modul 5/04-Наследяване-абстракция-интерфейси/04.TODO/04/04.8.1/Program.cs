using System;

namespace _04._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            AllPeople people = new AllPeople();
            string[] commandLine = Console.ReadLine().Split();
            while (!commandLine[0].Equals("End"))
            {
                if(commandLine.Length == 2)
                {
                    people.AddRobot(commandLine[0], commandLine[1]);
                }
                else
                {
                    people.AddCitizens(commandLine[0], int.Parse(commandLine[1]) , commandLine[2]);
                }
                commandLine = Console.ReadLine().Split();
            }
            string id = Console.ReadLine();
            Console.WriteLine(string.Join(Environment.NewLine , people.Arrest(id)));
        }
    }
}
