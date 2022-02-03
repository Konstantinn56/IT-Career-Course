using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster
{
    public class Truck : Vehicle
    {
        private const int capacity = 5;
        public Truck() : base(capacity)
        {
        }
    }
}
