using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster
{
    public class DistributionCenter : Storage
    {
        private const int capacity = 2;
        private const int garageSlots = 5;

        public DistributionCenter(string name) : base(name, capacity, garageSlots, new List<Vehicle> {new Van(), new Van(), new Van()})
        {
        }
    }
}
