using System;
using System.Collections.Generic;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> carList = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                double fuel = double.Parse(carInfo[1]);
                double fuelCost = double.Parse(carInfo[2]);
                Car car = new Car(model,fuel,fuelCost);
                carList.Add(car);
            }

            string[] info = Console.ReadLine().Split();
            while (!info[0].Equals("End"))
            {
                string model = info[1];
                int km = int.Parse(info[2]);
                //Car car = cars.Where(c => c.Model.Equals(model)).FirstOrDefault();
                foreach (Car car in carList)
                {
                    if (model.Equals(car.Model))
                    {
                        car.CarDrive(km);
                    }
                }
                info = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(Environment.NewLine, carList));
        }
    }
}
