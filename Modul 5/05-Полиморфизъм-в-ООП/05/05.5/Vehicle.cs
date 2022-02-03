using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._5
{
    class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double fuelCapacity;
        private double airConditioner;

        public Vehicle(double fQ , double fC ,double fuelCapacity, double airConditioner)
        {
            this.FuelQuantity = fQ;
            this.FuelConsumption = fC;
            this.FuelCapacity = fuelCapacity;
            this.airConditioner = airConditioner;
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            protected set 
            { 
                if(this.fuelQuantity < 0)
                {
                    throw new InvalidOperationException("Must me positive number");
                }
                fuelQuantity = value; 
            }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            protected set { fuelConsumption = value; }
        }
        public double FuelCapacity
        {
            get { return fuelCapacity; }
            protected set { fuelCapacity = value; }
        }

        public virtual string Drive(double distance)
        {
            double litersNeeded = distance * (this.FuelConsumption + this.airConditioner);
            if (litersNeeded > this.FuelQuantity)
            {
                return$"{this.GetType().Name} needs refueling";
            }
            this.FuelQuantity -= litersNeeded;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
            if(liters <= 0)
            {
                throw new InvalidOperationException("Must be positive number!");
            }
            if(this.FuelQuantity > this.FuelCapacity)
            {
                throw new InvalidOperationException("Cannot fit fuel in tank");
            }
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }

        
    }
}
