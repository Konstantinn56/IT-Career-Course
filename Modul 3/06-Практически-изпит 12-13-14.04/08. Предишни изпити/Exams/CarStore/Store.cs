using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarStore
{
    public class Store
    {
        private string name;
        private List<Car> carList;

        public Store(string name)
        {
            this.Name = name;
            this.CarList = new List<Car>();
        }

        ////////////////////////////////////////////////////////////////////////////
        
        public string Name
        {
            get { return name; }
            private set 
            {
                if (value.Length >= 5)
                {
                    name = value;
                }
                else
                    throw new ArgumentException("Invalid store name!");
            }
        }
        public List<Car> CarList
        {
            get { return carList; }
            private set
            {
                carList = value;
            }
        }

        ////////////////////////////////////////////////////////////////////////////

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.CarList.Count != 0)
            {
                sb.AppendLine($"Store {this.Name} has {this.CarList.Count} car/s:");
                foreach (var car in this.CarList)
                {
                    sb.AppendLine(car.ToString());
                }
            }
            else
                sb.AppendLine($"Store {this.Name} has no available cars.");
            return sb.ToString();
        }

        ////////////////////////////////////////////////////////////////////////////

        public void AddCar(Car car)
        {
            this.CarList.Add(car);
        }
        public bool SellCar(Car car)
        {
            foreach (var c in this.CarList)
            {
                if (c.Number.Equals(car.Number))
                {
                    this.CarList.Remove(c);
                    return true;
                }
            }
            return false;
        }
        public double CalculateTotalPrice()
        {
            double result = 0.0;
            foreach (var car in this.CarList)
            {
                result += car.Price;
            }
            return result;
        }
        public void RenameStore(string newName)
        {
            this.Name = newName;
        }
        public void SellAllCars()
        {
            this.CarList.RemoveRange(0, this.CarList.Count);
        }
        public Car GetCarWithHighestPrice()
        {
            return this.CarList.OrderByDescending(p => p.Price).First();
        }
        public Car GetCarWithLowestPrice()
        {
            return this.CarList.OrderBy(p => p.Price).First();
        }
    }
}
