using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMasterV2
{
    public class WareHouse : Storage
    {
        private const int capacity = 10;
        private const int garageSlots = 10;
        public WareHouse(string name) : base(name, capacity, garageSlots, new List<Vehicle> {new Semi(), new Semi(), new Semi()})
        {
        }
    }
}
