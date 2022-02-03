using System;
using System.Collections.Generic;
using System.Text;

namespace Train_SM
{
    public class Train
    {
        private int number;
        private string name;
        private string type;
        private int cars;

        public Train(int num, string name, string t, int c)
        {
            this.Number = num;
            this.Name = name;
            this.Type = t;
            this.Cars = c;
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Cars
        {
            get { return cars; }
            set { cars = value; }
        }
    }
}
