using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    public class CircularQueue<T>
    {
        private const int DefaultCapacity = 4;
        public int Count { get; set; }
        public int Capacity { get; set; }

        private int startIndex;
        private int endIndex;   
        public CircularQueue(int capacity = DefaultCapacity)
        {
            this.Capacity = capacity;
            this.elements = new T[this.Capacity];
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.startIndex = endIndex;
        }

        private T[] elements;

        public void Enqueue(T item)
        {
            if(this.Count >= this.elements.Length)
            {
                this.Grow();
            }
            this.elements[endIndex] = item;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }

        public T Dequeue()
        {
            //TO DO
            T element = this.elements[startIndex];
            int destinationIndex = startIndex;
            for (int i = startIndex; i < this.Count; i++)
            {
                this.elements[destinationIndex] = this.elements[(destinationIndex + 1) % this.elements.Length];
                destinationIndex = (destinationIndex + 1) % this.elements.Length;
            }
            //this.elements[this.endIndex-1] = default;
            //this.endIndex = (endIndex - 1) % this.elements.Length;
            //this.elements[this.endIndex] = default;
            //this.startIndex = (startIndex + 1) % this.elements.Length;
            this.Count--;
            return element;
        }

        public T Peek()
        {
            return this.elements[startIndex];
        }
        private void Grow()
        {
            this.Capacity *= 2;
            T[] newElements = new T[this.Capacity];
            this.CopyAllElementsTo(newElements);
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        private void CopyAllElementsTo(T[] newElements)
        {
            int sourceIndex = this.startIndex;
            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
            }

            this.elements = newElements;
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            this.CopyAllElementsTo(array);
            return array;
        }
    }
}
