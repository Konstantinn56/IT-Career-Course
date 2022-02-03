using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._5
{
    class Car : Vehicle
    {
        private const double airConditioner = 0.9;
        public Car(double fQ, double fC , double fCapacity) : base(fQ, fC, fCapacity, airConditioner)
        {
        }
    }
}
