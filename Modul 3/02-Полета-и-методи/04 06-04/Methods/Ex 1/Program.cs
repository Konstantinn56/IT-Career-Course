using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Gosho";
            firstPerson.Age = 15;

            firstPerson.IntroduceYourself();
        }
    }
}
