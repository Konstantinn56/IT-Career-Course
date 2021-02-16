using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ImperialSys = Console.ReadLine().ToLower();//miles,inches,feet,yards,gallons
            double value = double.Parse(Console.ReadLine());
            double Converter = 0;
            double ConvertedValue = 0;

            switch (ImperialSys)
            {
                case "miles":
                    ConvertedValue = value * 1.6;
                    Console.WriteLine($"{value} miles = {ConvertedValue:F2} kilometers");
                    break;

                case "inches":
                    ConvertedValue = value * 2.54;
                    Console.WriteLine($"{value} inches = {ConvertedValue:F2} centimeters");
                    break;

                case "feet":
                    ConvertedValue = value * 30;
                    Console.WriteLine($"{value} feet = {ConvertedValue:F2} centimeters");
                    break;

                case "yards":
                    ConvertedValue = value * 0.91;
                    Console.WriteLine($"{value} yards = {ConvertedValue:F2} meters");
                    break;

                case "gallons":
                    ConvertedValue = value * 3.8;
                    Console.WriteLine($"{value} gallons = {ConvertedValue:F2} liters");
                    break;

                default:
                    break;
            }
        }
        
    }
}
