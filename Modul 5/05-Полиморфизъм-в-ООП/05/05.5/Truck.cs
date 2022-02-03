using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._5
{
    class Truck : Vehicle
    {
        private const double airConditioner = 1.6;
        public Truck(double fQ, double fC, double fuelCapacity) : base(fQ, fC, fuelCapacity, airConditioner)
        {
        }
        public override void Refuel(double liters)
        {
            liters *= 0.95;
            base.Refuel(liters);
        }
    }
}
