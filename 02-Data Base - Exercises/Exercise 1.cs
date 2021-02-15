using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numType = Console.ReadLine();
            //“int”, “uint”, “long”, “byte” “sbyte”

            switch (numType)
            {
                case "int":
                    Console.WriteLine(int.MaxValue);
                    Console.WriteLine(int.MinValue);
                    break;

                case "uint":
                    Console.WriteLine(uint.MaxValue);
                    Console.WriteLine(uint.MinValue);
                    break;

                case "long":
                    Console.WriteLine(long.MaxValue);
                    Console.WriteLine(long.MinValue);
                    break;

                case "byte":
                    Console.WriteLine(byte.MaxValue);
                    Console.WriteLine(byte.MinValue);
                    break;

                case "sbyte":
                    Console.WriteLine(sbyte.MaxValue);
                    Console.WriteLine(sbyte.MinValue);
                    break;

                default:
                    break;
            }

        }

    }
}
