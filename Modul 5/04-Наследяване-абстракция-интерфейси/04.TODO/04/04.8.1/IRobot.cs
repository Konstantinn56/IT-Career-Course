using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._8._1
{
    abstract class IRobot : People
    {
        public string Model { get; set; }
        public IRobot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

    }
}
