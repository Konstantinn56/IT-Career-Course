using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Exam
{
    public class Deque<T> where T : Train
    {
        private const int defaultCapacity = 16;

        private Stack<Train> pTrains;
        private Stack<Train> fTrains;
        private Stack<Train> history;
        public Deque() : this(defaultCapacity)
        {
            //празен конструктор, задава капацитета на дека на стойността по подразбиране (16)
        }
        public Deque(int capacity)
        {
            this.Capacity = capacity;
            this.pTrains = new Stack<Train>(this.Capacity);
            this.fTrains = new Stack<Train>(this.Capacity);
            this.history = new Stack<Train>(this.Capacity);
        }
        public Deque(IEnumerable<T> collection)
             : this(collection.Count())
        {
            //създава дека с капацитет съответстващ на посочената колекция
            //и прехвърля елементите от колекцията в дека
            foreach (var train in collection)
            {
                if (train.Type.Equals("P"))
                {
                    pTrains.Push(train);
                }
                else if (train.Type.Equals("F"))
                {
                    fTrains.Push(train);
                }
            }
        }
        public int Capacity; //показва капацитета
        public int Count; //показва броят елементи
        public void AddFront(T item)
        {
            //добавя елемент отпред
            this.pTrains.Push(item);
            this.Count++;
        }
        public void AddBack(T item)
        {
            //добавя елемент отзад
            this.fTrains.Push(item);
            this.Count++;
        }
        public T RemoveFront()
        {
            //връща и премахва елемента отпред
            if(this.pTrains.Count > 0)
            {
                this.history.Push(this.pTrains.Peek());
                this.Count--;
                return (T)pTrains.Pop();
            }
            return default;
        }
        public T RemoveBack()
        {
            //връща и премахва елемента отзад
            if(this.fTrains.Count > 0)
            {
                this.history.Push(this.fTrains.Peek());
                this.Count--;
                return (T)this.fTrains.Pop();
            }
            return null;
        }
        public T GetFront()
        {
            //връща, без да премахва, елемента отпред
            if (this.pTrains.Any())
            {
                return (T)this.pTrains.Peek();
            }
            return default;
        }
        public T GetBack()
        {
            //връща, без да премахва, елемента отзад
            if (this.fTrains.Any())
            {
                return (T)this.fTrains.Peek();
            }
            return default;
        }

        public void GetHistory()
        {
            if (this.history.Any())
            {
                foreach (var item in this.history)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
