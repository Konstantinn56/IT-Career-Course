using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Exam
{
    public class Parking
    {
        private Car head;
        private Car tail;
        public int Count { get; private set; }

        public void AddCar(string carNumber)
        {
            Car car = new Car(carNumber);

            if(this.Count == 0)
            {
                this.head = car;
            }
            else
            {
                this.tail.Next = car;
            }

            this.tail = car;
            this.Count++;
        }

        public StringBuilder ParkingInformation()
        {
            StringBuilder sb = new StringBuilder();

            if (this.Count == 0)
            {
                return sb.AppendLine("Parking is empty!");
            }

            Car current = this.head;

            while(current != null)
            {
                sb.AppendLine(current.ToString());
                current = current.Next;
            }

            return sb;
        }

        public bool ReleaseCar(int index)
        {
            bool isReleased = false;
            if (index < 0 || index >= this.Count)
            {
                 isReleased = false;
            }

            int currentIndex = 0;
            Car currentCar = this.head;
            Car prevCar = null;
            while(currentCar != null)
            {
                if(currentIndex == index)
                {
                    if(prevCar == null)
                    {
                        this.head = this.head.Next;
                    }
                    else
                    {
                        prevCar.Next = currentCar.Next;
                    }
                    if(currentCar.Next == null)
                    {
                        this.tail = prevCar;
                    }
                    this.Count--;
                    isReleased = true;
                }

                currentIndex++;
                prevCar = currentCar;
                currentCar = currentCar.Next;
            }

            return isReleased;
        }

        public Car CheckCarIsPresent(string carNumber)
        {
            Car car = this.head;

            while(car != null)
            {
                if (car.CarNumber.Equals(carNumber))
                {
                    return car;
                }
                car = car.Next;
            }

            return null;
        }

        public void AddFancyCar(string carNumber)
        {
            Car car = new Car(carNumber);

            if(this.Count == 0)
            {
                this.head = car;
                this.tail = car;
            }
            else
            {
                car.Next = this.head;
                this.head = car;
            }

            this.Count++;
        }

        public bool ReleaseCar(string carNumber)
        {
            bool isReleased = false;
            int index = 0;
            Car current = this.head;
            while (current != null)
            {
                if (current.CarNumber.Equals(carNumber))
                {
                    isReleased = this.ReleaseCar(index);
                }

                current = current.Next;
                index++;
            }


            return isReleased;
        }


    }
}
