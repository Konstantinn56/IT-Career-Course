using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02._1
{
    public class ArrayList<T> : IEnumerable<T>
    {
        private T[] array;
        private int initialCapacity = 2;
        public ArrayList()
        {
            this.array = new T[this.initialCapacity];
        }
        public int Count { get; private set; }

        public T this[int index]
        {
            get 
            { 
                if(index < 0 || index > this.Count)
                {
                    throw new IndexOutOfRangeException("Index was outside of the array!");
                }
                return this.array[index]; 
            }
            set 
            {
                if (index < 0 || index > this.Count)
                {
                    throw new IndexOutOfRangeException("Index was outside of the array!");
                }
                this.array[index] = value; 
            }
        }
        public void Add(T item)
        {
            if (this.initialCapacity == this.Count)
            {
                this.Grow();
            }
            this.array[this.Count] = item;
            this.Count++;
        }
        public T RemoveAt(int index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException("Index was outside of the array!");
            }

            T removed = this.array[index];

            for (int i = index; i < this.array.Length - 1; i++)
            {
                this.array[i] = array[i + 1];
            }
            this.Count--;

            return removed;
        }
        private void Grow()
        {
            this.initialCapacity *= 2;
            T[] newArray = new T[initialCapacity];
            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }
            this.array = newArray;
        }
        //public bool Remove(T item)
        //{
        //    for (int i = 0; i < this.Count; i++)
        //    {
        //        if (this.array[i].CompareTo(item) == 0)
        //        {
        //
        //        }
        //    }
        //}

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.array[i];//za da vurne vsichki stoinosti na edin put,inache shte izleze na purviq
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
