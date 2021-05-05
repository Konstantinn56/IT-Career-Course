using System;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person1.Name = "Pesho";
            person2.Name = "Gosho";
            person3.Name = "Stamat";

            person1.Age = 20;
            person2.Age = 18;
            person3.Age = 43;

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);
        }
    }
}
