using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ImperialSys = Console.ReadLine().ToLower();//miles,inches,feet,yards,gallons
            double value = double.Parse(Console.ReadLine());
            double ConverterValue = 0;
            double ConvertedValue = 0;

            switch (ImperialSys)
            {
                case "miles":
                    ConverterValue = 1.6;
                    Converter("miles" , "kilometers" , value , ConvertedValue, ConverterValue);
                    break;

                case "inches":
                    ConverterValue = 2.54;
                    Converter("inches", "centimeters", value, ConvertedValue, ConverterValue);
                    break;

                case "feet":
                    ConverterValue = 30;
                    Converter("feet", "centimeters", value, ConvertedValue, ConverterValue);
                    break;

                case "yards":
                    ConverterValue = 0.91;
                    Converter("yards", "meters", value, ConvertedValue, ConverterValue);
                    break;

                case "gallons":
                    ConverterValue = 3.8;
                    Converter("gallons", "liters", value, ConvertedValue, ConverterValue);
                    break;

                default:
                    break;
            }
        }
        static void Converter(string FirstImprerialSys, string SecondImprerialSys , double value, double ConvertedValue , double ConverterValue)
        {
            ConvertedValue = value * ConverterValue;
            Console.WriteLine($"{value} {FirstImprerialSys} = {ConvertedValue:F2} {SecondImprerialSys}");
        }
    }
}
