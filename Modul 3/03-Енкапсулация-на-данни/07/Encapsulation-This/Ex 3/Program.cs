using System;
using System.Linq;
using System.Reflection;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length,width,height);

            double SArea = box.GetSurfaceArea();
            double LSArea = box.GetLateralSurfaceArea();
            double Volume = box.GetVolume();

            Console.WriteLine($"Surface Area - {SArea:f2}");
            Console.WriteLine($"Lateral Surface Area - {LSArea:f2}");
            Console.WriteLine($"Volume - {Volume:f2}");
        }
    }
}
