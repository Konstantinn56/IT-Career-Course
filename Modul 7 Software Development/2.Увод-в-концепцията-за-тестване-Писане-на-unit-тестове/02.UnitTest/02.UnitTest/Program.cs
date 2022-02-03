using System;

namespace _02.UnitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Divider d = new Divider();

            //Not automatic test
            Console.WriteLine($"4/2 = {d.Divide(4,2)}");


        }
    }
}