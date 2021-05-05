using System;
using System.Collections.Generic;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string model = info[0];

                int speed = int.Parse(info[1]);
                int power = int.Parse(info[2]);
                Engine engine = new Engine(speed, power);

                int weight = int.Parse(info[3]);
                string type = info[4];
                Cargo cargo = new Cargo(weight,type);

                List<Tire> tires = new List<Tire>();
                for (int a = 5; a < info.Length - 1; a+=2)
                {
                    double presure = double.Parse(info[5]);
                    int age = int.Parse(info[6]);
                    Tire tire = new Tire(presure, age);
                    tires.Add(tire);
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command.Equals("fragile"))
            {
                foreach (var c in cars)
                {
                    if (c.Cargo.Type.Equals("fragile"))
                    {
                        int count = 0;
                        foreach (var t in c.Tires)
                        {
                            if(t.Presure < 1)
                            {
                                count++;
                            }
                        }
                        if(count == 4)
                        {
                            Console.WriteLine(c.Model);
                        }
                    }
                }
            }
            else if (command.Equals("flamable"))
            {
                foreach (var c in cars)
                {
                    if (c.Cargo.Type.Equals("flamable") && c.Engine.Power > 250)
                    {
                        Console.WriteLine(c.Model);
                    }
                }
            }

        }
    }
}
