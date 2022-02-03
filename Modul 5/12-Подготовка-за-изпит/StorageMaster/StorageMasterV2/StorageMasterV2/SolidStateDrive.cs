using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMasterV2
{
    public class SolidStateDrive : Product
    {
        private const double weight = 0.2;
        public SolidStateDrive(double price) : base(price, weight)
        {
        }
    }
}
