using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMasterV2
{
    public class Gpu : Product
    {
        private const double weight = 0.7;
        public Gpu(double price) : base(price, weight)
        {
        }
    }
}
