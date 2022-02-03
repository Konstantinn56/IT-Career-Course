using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMasterV2
{
    public class Van : Vehicle
    {
        private const int capacity = 2;
        public Van() : base(capacity)
        {
        }
    }
}
