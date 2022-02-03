using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._5
{
    class Bus: Vehicle
    {
        private const double airConditioner = 1.4;
        public Bus(double fQuantity, double fCosumption, double tCapacity) : base(fQuantity, fCosumption, airConditioner, tCapacity)
        {
        }

        public override void Refuel(double amount)
        {
            if (base.FuelQuantity + amount > base.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                base.Refuel(amount);
            }
        }

        public override void DriveEmpty(double distance)
        {
            double fuelNeeded = distance * this.FuelConsumption;
            if (this.FuelQuantity < fuelNeeded)
            {
                Console.WriteLine($"The bus needs refueling!");
            }
            else
            {
                this.FuelQuantity -= fuelNeeded;
                Console.WriteLine($"The bus travelled {distance} km.");
            }
        }
    }
}
