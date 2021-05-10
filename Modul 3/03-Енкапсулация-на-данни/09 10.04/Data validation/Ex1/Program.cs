using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Person> personList = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine().Split();
                Person person = new Person(info[0], info[1],int.Parse(info[2]),double.Parse(info[3]));
                personList.Add(person);
            }
            int salaryBonus = int.Parse(Console.ReadLine());
            foreach (var p in personList.OrderBy(n => n.FirstName).ThenBy(n => n.Age))
            {
                p.IncreaseSalary(salaryBonus);
                Console.WriteLine(p.ToString());
            }
        }
    }
}
