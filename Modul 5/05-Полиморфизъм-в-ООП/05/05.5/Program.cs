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

            for (int i = 0; i < 2; i++)
            {
                string[] vehicleInfo = Console.ReadLine().Split();
                Vehicle vehicle = null;
                switch (vehicleInfo[0])
                {
                    case "Car":
                        {
                            vehicle = new Car(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));
                            break;
                        }
                    case "Truck":
                        {
                            vehicle = new Truck(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));
                            break;
                        }
                    case "Bus":
                        {
                            vehicle = new Bus(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));
                            break;
                        }
                }
                vehicles.Add(vehicle);
            }

            ////////////////////////////////////////////////////////////////////////////////////////////

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandLine = Console.ReadLine().Split();
                Vehicle vehicle = vehicle = vehicles.Where(v => v.GetType().Name.Equals(commandLine[1])).FirstOrDefault(); ;
                switch (commandLine[0])
                {
                    case "Drive":
                        Console.WriteLine(vehicle.Drive(double.Parse(commandLine[2])));
                        break;

                    case "Refuel":
                        vehicle.Refuel(double.Parse(commandLine[2]));
                        break;
                    case "DriveEmpty":
                        vehicle = (Bus)vehicle;
                        
                        break;
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(string.Join(Environment.NewLine, vehicles));
        }
    }
}
