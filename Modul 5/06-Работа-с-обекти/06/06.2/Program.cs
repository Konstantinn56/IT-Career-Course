using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            List<Person>  people = new List<Person>();
            while (!personInfo[0].Equals("END"))
            {
                Person person = new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]);
                people.Add(person);
                personInfo = Console.ReadLine().Split();
            }
            int n = int.Parse(Console.ReadLine());
            Person current = people[n - 1];
            int peopleCount = people.Count();
            int counterEquals = 0;
            int counterDiff = 0;
            foreach (var person in people)
            {
                if (person.CompareTo(current) == 0)
                {
                    counterEquals++;
                }
                else
                {
                    counterDiff++;
                }
            }
            if(counterEquals == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{counterEquals} {counterDiff} {peopleCount}");
            }
        } 
    }
}