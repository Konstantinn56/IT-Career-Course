using System;

namespace _04._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Rijko" , 2);
            Console.WriteLine(cat.Name);
            cat.MakeTrick();
            cat.MakeNoise();
        }
    }
}
