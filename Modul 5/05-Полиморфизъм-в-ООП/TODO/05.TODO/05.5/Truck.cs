using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._5
{
    class Truck : Vehicle
    {
        public const double airConditioner = 1.6;
        public Truck(double fQuantity, double fCosumption , double tCapacity) : base(fQuantity, fCosumption, airConditioner , tCapacity)
        {
        }
        public override void Refuel(double amount)
        {
            amount *= 0.95;
            base.Refuel(amount);
        }
    }
}
