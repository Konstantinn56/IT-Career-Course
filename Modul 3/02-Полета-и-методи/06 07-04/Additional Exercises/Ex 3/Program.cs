using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int engineCount = int.Parse(Console.ReadLine());
            List<Engine> engineList = new List<Engine>();
            for (int i = 0; i < engineCount; i++)
            {
                string[] line = Console.ReadLine().Split();
                string model = line[0];
                Engine engine = null;
                if(line.Length == 2)
                {
                    engine = new Engine(line[0], int.Parse(line[1]));
                }
                else if(line.Length == 3)
                {
                    int displacement = 0;
                    bool isInt = int.TryParse(line[2], out displacement);
                    if (isInt)
                    {
                        engine = new Engine(line[0], int.Parse(line[1]), displacement);
                    }
                    else
                    {
                        engine = new Engine(line[0], int.Parse(line[1]), line[2]);
                    }
                    
                }
                else
                {
                    engine = new Engine(line[0], int.Parse(line[1]), int.Parse(line[2]),line[3]);
                }
                engineList.Add(engine);
            }

            int carsCount = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0; i < carsCount; i++)
            {
                Car car = null;
                string[] info = Console.ReadLine().Split();
                Engine engine = engineList.Where(e => e.Model.Equals(info[1])).FirstOrDefault();
                if(info.Length == 2)
                {
                    car = new Car(info[0], engine);
                }
                else if(info.Length == 3)
                {
                    int weight = 0;
                    bool isInt = int.TryParse(info[2], out weight);
                    if (isInt)
                    {
                        car = new Car(info[0], engine, weight);
                    }
                    else
                    {
                        car = new Car(info[0], engine, info[2]);
                    }
                }
                else
                {
                    car = new Car(info[0], engine, info[3], int.Parse(info[2]));
                }
                carList.Add(car);
            }

            Console.WriteLine(string.Join(Environment.NewLine, carList));
        }
    }
}
