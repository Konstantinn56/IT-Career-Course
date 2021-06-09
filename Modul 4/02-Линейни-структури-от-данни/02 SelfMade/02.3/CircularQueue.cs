using System;
using System.Collections.Generic;
using System.Text;

namespace _02._3
{
    public class CircularQueue<T>
    {
        private T[] elements;
        private const int DefaultCpacity = 4;
        public T[] Elements
        {
            get { return elements; }
            set { elements = value; }
        }
        public int InitialCapacity { get; private set; }
        public int Count { get; private set; }
        public int startIndex { get; private set; }
        public int endIndex { get; private set; }

        public CircularQueue(int capacity = DefaultCpacity)
        {
            this.InitialCapacity = capacity;
            this.Elements = new T[this.InitialCapacity];
            this.startIndex = 0;
            this.endIndex = 0;
        }
        
        public void Enqueue(T element)
        {
            T newElement = element;
            if(this.Count == this.InitialCapacity)
            {
                this.Grow();
            }
            this.elements[this.endIndex] = newElement;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }
        public T Dequeue()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }
            T elementToRemove = this.Elements[this.startIndex];
            this.Elements[this.startIndex] = default(T);
            this.startIndex = (this.startIndex + 1) % this.elements.Length;
            this.Count--;
            return elementToRemove;
        }
        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            this.CopyAllElementsTo(arr);
            return arr;
        }



        private void Grow()
        {
            this.InitialCapacity *= 2;
            T[] copy = new T[this.InitialCapacity];
            this.CopyAllElementsTo(copy);
            this.Elements = copy;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }
        private void CopyAllElementsTo(T[] arr)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                arr[destinationIndex] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
                destinationIndex++;
            }
        }
    }
}
