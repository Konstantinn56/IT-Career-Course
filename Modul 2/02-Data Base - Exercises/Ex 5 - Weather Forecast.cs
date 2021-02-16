using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string DataType = Console.ReadLine();//sbyte , int , long
            int rows = int.Parse(Console.ReadLine());
            double ThiefId = 0;

            switch (DataType)
            {
                case "sbyte":
                    ThiefId = sbyte.MinValue;
                    for (int i = 0; i < rows; i++)
                    {
                        double id = double.Parse(Console.ReadLine());
                        if(id > ThiefId && id <= sbyte.MaxValue)
                        {
                            ThiefId = id;
                        }
                    }
                    break;

                case "int":
                    ThiefId = int.MinValue;
                    for (int i = 0; i < rows; i++)
                    {
                        double id = double.Parse(Console.ReadLine());
                        if (id > ThiefId && id <= int.MaxValue)
                        {
                            ThiefId = id;
                        }
                    }
                    break;

                case "long":
                    ThiefId = long.MinValue;
                    for (int i = 0; i < rows; i++)
                    {
                        double id = double.Parse(Console.ReadLine());
                        if (id > ThiefId && id <= long.MaxValue)
                        {
                            ThiefId = id;
                        }
                    }
                    break;

                default:
                    break;

            }
        }

    }
}
