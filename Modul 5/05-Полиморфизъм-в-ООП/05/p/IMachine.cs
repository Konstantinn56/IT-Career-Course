using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p
{
    interface IMachine
    {
        string MachineType { get; }
        bool Start();
        bool Stop();
    }
}
