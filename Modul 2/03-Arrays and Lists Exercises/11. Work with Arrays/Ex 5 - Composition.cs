using System;
using System.Linq;

namespace asdg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bread Juice Fruits Lemons
            string[] ProductsNames = Console.ReadLine()
                .Split();
            //10 50 20 30
            long[] ProductsQuantity = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            //2.34 1.23 3.42 1.50
            double[] ProductsPrices = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            ////////////////////////////////////////////////////////
            string[] Command = new string[1];
            while (Command[0] != "done")
            {
                Command[0] = Console.ReadLine();
                if (ProductsNames.Contains(Command[0]))
                {
                    string searchingProduct = Command[0];
                    int index = Array.IndexOf(ProductsNames, searchingProduct);
                    Console.WriteLine($"{ProductsNames[index]} costs: {ProductsPrices[index]}; Available quantity: {ProductsQuantity[index]}");
                }
                else if (Command[0] != "done")
                {
                    Console.WriteLine("Invalid product!");
                }
            }
        }
    }
}
