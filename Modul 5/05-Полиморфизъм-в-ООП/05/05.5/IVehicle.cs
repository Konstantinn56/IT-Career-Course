using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._5
{
    interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }
        double FuelCapacity { get; }

        string Drive(double distance);
        void Refuel(double liters);

    }
}
