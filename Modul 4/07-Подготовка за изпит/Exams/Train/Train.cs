using System;
using System.Collections.Generic;
using System.Text;

namespace Train
{
    public class Train
    {
        private int number;
        private string name;
        private string type;
        private int cars;

        public Train(int number,string name,string type,int cars)
        {
            this.Number = number;
            this.Name = name;
            this.Type = type;
            this.Cars = cars;
        }

        public int Number
        {
            get { return number; }
            private set { number = value; }
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public string Type
        {
            get { return type; }
            private set { type = value; }
        }
        public int Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public override string ToString()
        {
            return $"{this.Number} {this.Name} {this.Type} {this.Cars}";
        }
    }
}
