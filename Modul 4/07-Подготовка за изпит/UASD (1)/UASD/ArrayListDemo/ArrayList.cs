using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    public class ArrayList<T> : IEnumerable<T> 
    {
        private T[] array;
        private int initialCapacity = 2;
        public ArrayList()
        {
            this.array = new T[initialCapacity];
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException("Index was outside of the array!");
            }

            T removed = this.array[index];

            for (int i = index; i < this.Count; i++)
            {
                this.array[i] = this.array[i + 1];
            }

            this.Count--;

            return removed;
        }

        //public bool Remove(T item)
        //{
        //    for (int i = 0; i < this.Count; i++)
        //    {
        //        if(this.array[i].CompareTo(item) == 0)
        //        {

        //        }
        //    }
        //}

        public int Count { get; private set; }//0
        public void Add(T item)
        {
            if(this.Count == this.initialCapacity)
            {
                this.Grow();
            }
            this.array[this.Count] = item;
            this.Count++;
        }

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

        private void Grow()
        {
            this.initialCapacity *= 2;//4->8
            T[] newArray = new T[initialCapacity];
            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
