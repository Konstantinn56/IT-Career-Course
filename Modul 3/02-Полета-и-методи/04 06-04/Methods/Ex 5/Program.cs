using System;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            People people = new People();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);
                Person person = new Person(name,age);
                people.AddPerson(person);
            }

            People peopleOver30 = people.PeopleOver30(people.Peoples);

            foreach (var p in peopleOver30.Peoples)
            {
                Console.WriteLine(p);
            }
        }
    }
}
