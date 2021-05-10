using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("ASD",123);
            Person person2 = new Person("ASDasd",112323);
            Person person3 = new Person("ASasdD",123123);

            Console.WriteLine(Person.Counter);
        }
    }
}
