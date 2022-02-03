using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._5
{
    class Car : Vehicle
    {
        public const double airConditioner = 0.9;
        public Car(double fQuantity, double fCosumption , double tCapacity) : base(fQuantity, fCosumption , airConditioner, tCapacity)
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
    }
}
