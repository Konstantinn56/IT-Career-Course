using System;
using System.Collections.Generic;
using System.Text;

namespace _02._3
{
    public class CircularQueue<T>
    {
        private const int DefaultCapacity = 4;
        private T[] elements;
        private int startIndex;
        private int endIndex;

        public int Count { get; set; }
        public int Capacity { get; set; }

        //////////////////////////////////////////////////////////////////////////////

        public CircularQueue(int capacity = DefaultCapacity)//kogato mu dadut prazno shte vzima defaulta
        {
            this.Capacity = capacity;
            this.elements = new T[this.Capacity];
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.startIndex = endIndex;
        }

        //////////////////////////////////////////////////////////////////////////////

        public void Enqueue(T item)
        {
            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }
            this.elements[endIndex] = item;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }

        public T Dequeue()
        {
            T element = this.elements[startIndex];

            for (int i = startIndex; i < this.Count; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.startIndex = (startIndex + 1) % this.elements.Length;
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
    }
}
