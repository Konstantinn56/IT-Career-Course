using System;
using System.Linq;

namespace asfasgfasg
{
    class Program
    {
        static void Main(string[] args)
        {
            //  0     1      2      3     4
            //Bread Juice Fruits Lemons Beer
            string[] ProductsNames = Console.ReadLine()
                .Split();
            // 0  1  2  3
            //10 50 20 30
            long[] ProductsQuantity = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            //  0    1    2    3    4
            //2.34 1.23 3.42 1.50 3.00
            double[] ProductsPrices = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            ////////////////////////////////////////////////////////
            string[] Command = new string[2];
            while (Command[0] != "done")
            {
                Command = Console.ReadLine().Split();
                string searchingProduct = Command[0];
                if (ProductsNames.Contains(searchingProduct))
                {
                    int index = Array.IndexOf(ProductsNames, searchingProduct);
                    if(index < ProductsQuantity.Length- 1)
                    {
                        int SearchingProductQuantity = int.Parse(Command[1]);
                        if(SearchingProductQuantity <= ProductsQuantity[index])
                        {
                            double SumCosts = (ProductsPrices[index] * SearchingProductQuantity);
                            ProductsQuantity[index] -= SearchingProductQuantity;
                            Console.WriteLine($"{ProductsNames[index]} x {SearchingProductQuantity} costs {SumCosts:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"We do not have enough {searchingProduct}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"We do not have enough {searchingProduct}");
                    }
                }
                else if (Command[0] != "done")
                {
                    Console.WriteLine("Invalid product!");
                }
            }
        }
    }
}
