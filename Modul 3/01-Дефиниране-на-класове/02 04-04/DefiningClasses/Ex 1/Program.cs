using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person person = new Person();
            person.Name = name;
            person.Age = age;

            Console.WriteLine(person);
        }
    }
}
