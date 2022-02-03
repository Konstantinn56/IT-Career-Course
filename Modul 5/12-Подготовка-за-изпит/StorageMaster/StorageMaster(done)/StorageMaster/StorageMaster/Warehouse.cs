using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster
{
    public class Warehouse : Storage
    {
        private const int capacity = 10;
        private const int garageSlots = 10;
        public Warehouse(string name)
            : base(name, capacity, garageSlots, new List<Vehicle> { new Semi(), new Semi(), new Semi()})
        {
        }
    }
}
