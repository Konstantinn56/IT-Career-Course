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
        private double airConditioner;
        private double tankCapacity;

        public Vehicle(double fQuantity , double fCosumption, double airConditioner , double tCapacity)
        {
            this.FuelQuantity = fQuantity;
            this.FuelConsumption = fCosumption;
            this.airConditioner = airConditioner;
            this.TankCapacity = tCapacity;
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            protected set 
            { 
                if(value == 0)
                {
                    Console.WriteLine("Fuel must be a positive number!");
                }
                else
                {
                    fuelQuantity = value;
                }
                
            }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            protected set { fuelConsumption = value; }
        }
        public double TankCapacity
        {
            get { return tankCapacity; }
            protected set { tankCapacity = value; }
        }

        public void Drive(double distance)
        {
            string vName = this.GetType().Name;
            double fuelNeeded = distance * (this.FuelConsumption + airConditioner);
            if(this.fuelQuantity < fuelNeeded)
            {
                Console.WriteLine($"{vName} needs refueling!");
            }
            else
            {
                this.FuelQuantity -= fuelNeeded;
                Console.WriteLine($"{vName} travelled {distance} km.");
            }
            
        }

        public virtual void Refuel(double amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("The amount must be possitive number!");
            }
           
            else
            {
                this.FuelQuantity += amount;
            }
            
        }
        public virtual void DriveEmpty(double distance)
        {
            
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
