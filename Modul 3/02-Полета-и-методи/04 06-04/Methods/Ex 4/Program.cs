using System;
using System.Collections.Generic;
using System.Reflection;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            int n = int.Parse(Console.ReadLine());

            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);
                Person person = new Person(name,age);

                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMember(family.Members);
            Console.WriteLine(oldestPerson);
        }
    }
}
