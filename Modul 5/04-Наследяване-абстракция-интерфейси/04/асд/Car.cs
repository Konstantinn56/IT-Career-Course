using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace асд
{
    class Car : ICar
    {
        public Car(string model , string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; set; }

        public string Color { get; set; }

        public string Start()
        {
            return $"{this.Model} Engine start";
        }

        public string Stop()
        {
            return "Break!";
        }
    }
}
