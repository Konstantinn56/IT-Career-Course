using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    public class CustomStack<T>
    {
        private const int InitialCapacity = 2;
        public int Count { get; set; }
        public int Capacity { get; set; }

        private T[] items;
        public CustomStack(int capacity = InitialCapacity)
        {
            this.Capacity = capacity;
            this.items = new T[this.Capacity];
        }

        public void Push(T item)
        {
            if(this.Count >= this.items.Length)
            {
                this.Grow();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public T Pop()
        {
            T item = this.Peek();

            this.items[this.Count - 1] = default;
            this.Count--;
            return item;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return this.items[this.Count - 1];
        }
        private void Grow()
        {
            this.Capacity *= 2;
            T[] newItems = new T[this.Capacity];
            for (int i = 0; i < this.items.Length; i++)
            {
                newItems[i] = this.items[i];
            }

            this.items = newItems;
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                array[i] = this.items[this.Count - 1 - i];
            }

            return array;
        }
    }
}
