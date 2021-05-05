using System;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PeopleOver30 people = new PeopleOver30();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);

                Person person = new Person();
                person.name = name;
                person.age = age;

                people.peopleOver30.Add(person);
            }

            people.PrintPeopleOver30();
        }
    }
}
