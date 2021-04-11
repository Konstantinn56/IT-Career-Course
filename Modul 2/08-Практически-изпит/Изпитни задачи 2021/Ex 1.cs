using System;
using System.Collections.Generic;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());
            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;
            int maxEggCount = 0;
            string maxEggColor = null;

            for (int i = 0; i < eggsCount; i++)
            {
                string eggColor = Console.ReadLine();
                switch (eggColor)
                {
                    case "red":
                        red++;
                        break;
                    case "orange":
                        orange++;
                        break;
                    case "blue":
                        blue++;
                        break;
                    case "green":
                        green++;
                        break;
                    default:
                        break;
                }
                if(maxEggCount < red)
                {
                    maxEggCount = red;
                    maxEggColor = "red";
                }
                else if (maxEggCount < orange)
                {
                    maxEggCount = orange;
                    maxEggColor = "orange";
                }
                else if (maxEggCount < blue)
                {
                    maxEggCount = blue;
                    maxEggColor = "blue";
                }
                else if (maxEggCount < green)
                {
                    maxEggCount = green;
                    maxEggColor = "green";
                }
            }
            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {maxEggCount} -> {maxEggColor}");
        }
    }
}
