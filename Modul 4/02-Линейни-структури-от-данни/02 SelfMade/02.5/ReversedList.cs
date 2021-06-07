using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02._5
{
    public class ReversedList<T> : IEnumerable<T>
    {
        private T[] items;
        private int capacity = 2;
        public int Count { get; private set; }
        public int Capacity 
        {
            get
            {
                return capacity;
            }
            private set
            {
                capacity = value;
            }
        }

        public ReversedList()
        {
            this.items = new T[this.Capacity];
        }
        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.items[index];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                this.items[index] = value;
            }
        }

        public void Add(T item)
        {
            if(this.Count == this.Capacity)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
            T elementToRemove = this.items[this.Count - index - 1];
            this.items[this.Count - index - 1] = default(T);
            this.Shift(index);
            this.Count--;

            if(this.Count == this.Capacity / 2)
            {
                this.Schrink();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////

        private void Resize()
        {
            this.Capacity *= 2;
            T[] copy = new T[this.Capacity];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        private void Shift(int index)
        {
            int removedIndex = this.Count - index - 1;
            for (int i = removedIndex; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
            this.items[this.Count - 1] = default(T);
        }
        private void Schrink()
        {
            this.Capacity /= 2;
            T[] copy = new T[this.Capacity];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.items[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
