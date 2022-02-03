using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster
{
    class AutomatedWarehouse : Storage
    {
        private const int capacity = 1;
        private const int garageSlots = 2;
        
        public AutomatedWarehouse(string name) 
            : base(name, capacity, garageSlots, new List<Vehicle> { new Truck() })
        {
        }
    }
}
