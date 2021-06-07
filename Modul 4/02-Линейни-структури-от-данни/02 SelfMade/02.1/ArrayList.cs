using System;
using System.Collections.Generic;
using System.Text;

namespace _02._1
{
    public class ArrayList<T>
    {
        private T[] items;
        private int initialCapacity = 2;
        public int Count { get; private set; }

        public ArrayList()
        {
            this.items = new T[this.initialCapacity];
        }

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("The index is out of range!");
                }
                return this.items[index];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("The index is out of range!");
                }
                this.items[index] = value;
            }
        }

        public void Add(T item)
        {
            this.Count++;
            if(this.Count > this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count - 1] = item;
        }
        public T RemoveAt(int index)
        {
            if(index > this.Count - 1)
            {
                throw new IndexOutOfRangeException("The index is out of range!");
            }
            T elementToRemove = this.items[index];
            this.items[index] = default(T);
            this.Shift(index);
            Count--;

            if(this.Count == this.items.Length / 2)
            {
                this.Schrink();
            }

            return elementToRemove;
        }


        ///////////////////////////////////////////////////////////////////////////
        private void Schrink()
        {
            this.initialCapacity /= 2;
            T[] copy = new T[this.initialCapacity];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        private void Shift(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }
        private void Resize()
        {
            this.initialCapacity *= 2;
            T[] copy = new T[this.initialCapacity];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
    }
}
