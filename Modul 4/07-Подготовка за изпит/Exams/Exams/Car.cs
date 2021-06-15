using System;
using System.Collections.Generic;
using System.Text;

namespace Exams
{
    public class Car
    {
        private string carNumber;
        private Car next;

        public Car(string number)
        {
            this.CarNumber = number;
        }

        public string CarNumber
        {
            get { return carNumber; }
            set { carNumber = value; }
        }
        public Car Next
        {
            get { return next; }
            set { next = value; }
        }

        public override string ToString()
        {
            return $"Car {this.CarNumber}";
        }
    }
}
