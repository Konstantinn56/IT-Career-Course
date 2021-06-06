using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._5
{
    public class ReversedList<T> : IEnumerable<T>
    {
        private T[] items;
        private const int initialCapacity = 2;
        public int Count { get; set; }
        public int Capacity { get; set; }

        public ReversedList(int capacity = initialCapacity)
        {
            this.Capacity = capacity;
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
                return this.items[this.Count - 1 - index];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                this.items[this.Count - 1 - index] = value;

            }
        }
        public void Add(T item)
        {
            if(this.Count >= this.items.Length)
            {
                this.Grow();
            }

            this.items[this.Count] = item;
            this.Count++;
        }
        public T RemoveAt(int index)
        {
            T element = this.items[this.Count - 1 - index];

            this.items = this.items.Take(this.Count - 1 - index).ToArray();
            this.items = this.items.Concat(this.items.Skip(this.Count - index)).ToArray();
            this.Count--;
            return element;
        }

        private void Grow()
        {
            this.Capacity *= 2;
            T[] newItems = new T[this.Capacity];
            for (int i = 0; i < this.Count; i++)
            {
                newItems[i] = this.items[i];
            }
            this.items = newItems;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count-1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
