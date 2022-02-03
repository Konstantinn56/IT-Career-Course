using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._5
{
    class Bus : Vehicle
    {
        private const double airConditioner = 1.4;
        public Bus(double fQ, double fC, double fCapacity) : base(fQ, fC, fCapacity, airConditioner)
        {
        }

        public string DriveEmpty(double distance)
        {
            double litersNeeded = distance * (this.FuelConsumption);

            if (litersNeeded > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            base.FuelQuantity -= litersNeeded;
            return $"{this.GetType().Name} travelled {distance} km";
        }
    }
}
