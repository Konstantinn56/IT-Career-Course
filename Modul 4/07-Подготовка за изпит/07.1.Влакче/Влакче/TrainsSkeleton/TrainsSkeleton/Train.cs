using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsSkeleton
{
    class Train
    {
        private int number;
        private string name;
        private string type;
        private int cars;

        public Train(int number, string name, string type, int cars)
        {
            throw new NotImplementedException();
        }


        public string Type { get; set; }

        public int Cars { get; set; }
    }
}
