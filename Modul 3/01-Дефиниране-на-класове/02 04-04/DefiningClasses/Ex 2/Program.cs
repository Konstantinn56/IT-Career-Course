using System;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Family familyy = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person();
                person.name = name;
                person.age = age;

                familyy.people.Add(person);
            }

            familyy.PrintPeople();
        }
    }
}
