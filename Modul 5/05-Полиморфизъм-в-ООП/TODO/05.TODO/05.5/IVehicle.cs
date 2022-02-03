using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._5
{
    interface IVehicle
    {
        public double FuelQuantity { get;}
        public double FuelConsumption { get; }
        public double TankCapacity { get;}
        void Drive(double distance);
        void Refuel(double amount);
        void DriveEmpty(double distance);


    }
}
