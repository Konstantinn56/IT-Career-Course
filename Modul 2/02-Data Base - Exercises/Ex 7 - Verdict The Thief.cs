using System;

namespace Ex_7___Verdict_The_Thief
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
                        if (id > ThiefId && id <= sbyte.MaxValue)
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
            double Verdict = Math.Ceiling(ThiefId / 127);
            if (Verdict > 1)
            {
                Console.WriteLine($"Prisoner with id {ThiefId} is sentenced to {Verdict} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {ThiefId} is sentenced to {Verdict} year");
            }
        }
    }
}
