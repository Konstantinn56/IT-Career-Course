using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_3
{
    public class Car
    {

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Color = "n/a";
            this.Weight = -1;
        }

        public Car(string model, Engine engine , string color) : this(model, engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color , int weight) : this(model, engine, color)
        {
            this.Weight = weight; 
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}");
            sb.AppendLine($"  {this.Engine}");
            if (this.Weight != -1)
                sb.AppendLine($"Weight: {this.Weight}");
            else
                sb.AppendLine($"Weight: n/a");
            sb.AppendLine($"Color: {this.Color}");

            return sb.ToString();
        }
    }
}
