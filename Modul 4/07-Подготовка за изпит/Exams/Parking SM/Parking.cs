using System;
using System.Collections.Generic;
using System.Text;

namespace Parking_SM
{
    public class Parking
    {
        private Car head;
        private Car tail;
        public Parking()
        {
            this.Head = this.Tail = null;
            this.Count = 0;
        }

        public Car Head
        {
            get { return head; }
            set { head = value; }
        }
        public Car Tail
        {
            get { return tail; }
            set { tail = value; }
        }
        public int Count { get; set; }

        public void AddCar(string carNumber)
        {
            Car newCar = new Car(carNumber);
            if(this.Count == 0)
            {
                this.Head = newCar;
            }
            else
            {
                this.Tail.Next = newCar;
            }
            this.Tail = newCar;
            this.Count++;
        }
        public void AddFancyCar(string carNumber)
        {
            Car newCar = new Car(carNumber);
            newCar.Next = this.Head;
            this.Head = newCar;
        }
        public Car CheckCarIsPresent(string carNumber)
        {
            if(this.Count == 0)
            {
                return null;
            }
            Car current = this.Head;
            while (current != null)
            {
                if (current.CarNumber.Equals(carNumber))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public bool ReleaseCar(int arg)
        {
            if (this.Count == 0 || arg > this.Count)
            {
                throw new IndexOutOfRangeException();
            }
            int index = 0;
            Car current = this.Head;
            while (index != arg)
            {
                current = current.Next;
                index++;
            }
            return ReleaseCar(current.CarNumber);
        }
        public bool ReleaseCar(string arg)
        {
            if(this.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            Car current = this.Head;
            Car prev = null;
            while (current != null)
            {
                if (current.CarNumber.Equals(arg))
                {
                    if(this.Count == 1)
                    {
                        this.Head = this.Tail = null;
                    }
                    else if (this.Head == current)
                    {
                        this.Head = this.Head.Next;
                    }
                    else if(this.Tail == current)
                    {
                        prev.Next = null;
                        this.Tail = prev;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }
                    return true;
                }
                prev = current;
                current = current.Next;
            }
            return false;
        }
        public StringBuilder ParkingInformation()
        {
            StringBuilder sb = new StringBuilder();
            Car current = this.Head;
            if(this.Count == 0)
            {
                sb.AppendLine("Parking is empty!");
            }
            else
            {
                while (current != null)
                {
                    sb.AppendLine(current.ToString());
                    current = current.Next;
                }
            }
            return sb;

        }
    }
}
