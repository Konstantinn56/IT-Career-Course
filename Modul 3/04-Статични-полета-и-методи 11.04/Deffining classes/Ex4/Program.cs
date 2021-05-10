using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split();
            while (!info[0].Equals("Close"))
            {
                switch (info[0])
                {
                    case "Add":
                        StoreController.Add(info[1], info[2], double.Parse(info[4]), double.Parse(info[3]));
                        break;
                    case "Sell":
                        Console.WriteLine(StoreController.Sell(info[1], double.Parse(info[2])));
                        break;
                    case "Update":
                        Console.WriteLine(StoreController.Update(info[1], double.Parse(info[2])));
                        break;
                    case "PrintA":
                        StoreController.PrintA();
                        break;
                    case "PrintU":
                        StoreController.PrintU();
                        break;
                    case "PrintD":
                        StoreController.PrintD();
                        break;
                    case "Calculate":
                        Console.WriteLine(StoreController.Calculate());
                        break;
                }
                info = Console.ReadLine().Split();
            }
        }
    }
}
