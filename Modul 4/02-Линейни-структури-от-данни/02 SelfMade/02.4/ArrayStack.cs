using System;
using System.Collections.Generic;
using System.Text;

namespace _02._4
{
    public class ArrayStack<T>
    {
        private T[] elements;
        private int top = -1;
        public int Count { get; private set; }
        private const int DefaultCapacity = 4;
        public int InitialCapacity { get; private set; }

        public ArrayStack(int capacity = DefaultCapacity)
        {
            this.InitialCapacity = capacity;
            this.elements = new T[capacity];
        }

        public void Push(T element) 
        {
            if(this.Count == this.InitialCapacity)
            {
                this.Grow();
            }
            this.elements[this.top + 1] = element;
            this.Count++;
            this.top++;
        }
        
        
        public T Pop()
        {
            T result = this.elements[this.top];
            if(this.Count == 0)
            {
                throw new InvalidOperationException();
            }
            this.elements[this.top] = default(T);
            this.top--;
            this.Count--;
            return result;
        }
        
        public T[] ToArray()
        {
            T[] result = new T[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                result[i] = this.elements[i];
            }
            return result;
        }
        
        private void Grow()
        {
            this.InitialCapacity *= 2;
            T[] copy = new T[this.InitialCapacity];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.elements[i];
            }
            this.elements = copy;
        }


    }
}
