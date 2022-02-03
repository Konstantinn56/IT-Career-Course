using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace асд
{
    interface ICar
    {
        public string Model { get;}
        public string Color { get;}
        string Start();
        string Stop();

    }
}
