using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string[] commandLine = null;
            Vehicle vehicle = null;

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 3; i++)
            {
                commandLine = Console.ReadLine().Split();
                switch (commandLine[0])
                {
                    case ("Car"):
                        {
                            vehicle = new Car(double.Parse(commandLine[1]) , double.Parse(commandLine[2]) ,double.Parse(commandLine[3]));
                            break;
                        }
                    case ("Truck"):
                        {
                            vehicle = new Truck(double.Parse(commandLine[1]), double.Parse(commandLine[2]), double.Parse(commandLine[3]));
                            break;
                        }
                    case ("Bus"):
                        {
                            vehicle = new Bus(double.Parse(commandLine[1]), double.Parse(commandLine[2]), double.Parse(commandLine[3]));
                            break;
                        }
                }
                vehicles.Add(vehicle);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int n = int.Parse(Console.ReadLine());

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < n; i++)
            {
                commandLine = Console.ReadLine().Split();
                string vehicleType = commandLine[1];
                vehicle = vehicles.Where(v => v.GetType().Name.Equals(vehicleType)).FirstOrDefault();
                switch (commandLine[0])
                {
                    case ("Drive"):
                        {
                            vehicle.Drive(double.Parse(commandLine[2]));
                            break;
                        }
                    case ("Refuel"):
                        {
                            vehicle.Refuel(double.Parse(commandLine[2]));
                            break;
                        }
                    case ("DriveEmpty"):
                        {
                            vehicle.DriveEmpty(double.Parse(commandLine[2]));
                            break;
                        }
                }
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////

            foreach (var v in vehicles)
            {
                Console.WriteLine(v);
            }
        }
    }
}
