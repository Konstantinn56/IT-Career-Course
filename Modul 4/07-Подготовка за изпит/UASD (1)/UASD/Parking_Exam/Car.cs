using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Exam
{
    public class Car
    {
        private string carNumber;
        private Car next;

        public Car(string carNumber)
        {
            this.CarNumber = carNumber;
        }

        public string CarNumber
        {
            get { return carNumber; }
            private set { carNumber = value; }
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
