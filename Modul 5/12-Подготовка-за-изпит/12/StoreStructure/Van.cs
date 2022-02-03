using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster
{
    public class Van : Vehicle
    {
        private const int capacity = 2;
        public Van() : base(capacity)
        {
        }
    }
}
