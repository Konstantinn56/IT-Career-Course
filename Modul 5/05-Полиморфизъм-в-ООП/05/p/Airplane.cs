using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p
{
    class Airplane : IMachine
    {
        private string machineType;

        public string MachineType
        {
            get { return machineType; }
            private set { machineType = value; }
        }


        public bool Start()
        {
            Console.WriteLine("Airplane starting...");
            return true;         }

        public bool Stop()
        {
            Console.WriteLine("Airplane stopping...");
            return true;
        }
    }
}
