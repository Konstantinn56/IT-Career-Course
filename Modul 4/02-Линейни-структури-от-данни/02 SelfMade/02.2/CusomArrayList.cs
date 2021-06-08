using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._2
{
    public class CusomArrayList<T>
    {
		private T[] arr;
		private int INITIAL_CAPACITY = 4;
		private int count;
		public int Count
		{
			get
			{
				return count;
			}
			private set
            {
				this.count = value;
            }
		}

        public CusomArrayList()
        {
			this.arr = new T[INITIAL_CAPACITY];
			this.count = 0;
		}

		public T this[int index]
		{
            get
            {
				if(index < 0 || index >= this.count)
                {
					throw new IndexOutOfRangeException();
                }
				return this.arr[index];
            }
            set
            {
				if (index < 0 || index >= this.count)
				{
					throw new IndexOutOfRangeException();
				}
				this.arr[index] = value;
			}
		}

		//////////////////////////////////////////////////////////////////////
		private void Resize()
		{
			this.INITIAL_CAPACITY *= 2;
			T[] copy = new T[this.INITIAL_CAPACITY];
			for (int i = 0; i < this.Count; i++)
			{
				copy[i] = this.arr[i];
			}
			this.arr = copy;
		}
		private void Shift(int index)
		{
            for (int i = index; i < this.Count; i++)
            {
				this.arr[i] = this.arr[i + 1];
            }
			this.arr[Count] = default(T);
		}
		
		public void Add(T item)
		{
			if(this.Count == this.INITIAL_CAPACITY)
            {
				this.Resize();
            }
			this.arr[this.Count] = item;
			this.Count++;
		}
        public void Insert(int index, T item)
		{
			if(index < 0 || index >= this.INITIAL_CAPACITY)
            {
				throw new IndexOutOfRangeException();
            }
			this.arr[index] = item;
		}
		public int IndexOf(T item)
		{
            for (int i = 0; i < this.Count; i++)
            {
				if(this.arr[i].ToString().Equals(item.ToString()))
                {
					return i;
                }
            }
			throw new IndexOutOfRangeException();
		}
		public void Clear()
		{
            for (int i = 0; i < this.INITIAL_CAPACITY; i++)
            {
				this.arr[i] = default(T);
            }
		}
		public bool Contains(T item)
		{
            for (int i = 0; i < this.INITIAL_CAPACITY; i++)
            {
                if (this.arr[i].ToString().Equals(item.ToString()))
                {
					return true;
                }
            }
			return false;
		}
		public T Remove(int index)
		{
			if (index < 0 || index >= this.INITIAL_CAPACITY)
			{
				throw new IndexOutOfRangeException();
			}
			T itemToRemove = this.arr[index];
			this.arr[index] = default(T);
			this.Count--;
			this.Shift(index);
			return itemToRemove;
		}
        public int Remove(T item)
		{
			T elementToRemove = default(T);
			int index = default;
			for (int i = 0; i < this.Count; i++)
            {
				if (this.arr[i].ToString().Equals(item.ToString()))
                {
					elementToRemove = this.arr[i];
					index = i;
					this.arr[index] = default(T);
					this.Count--;
					this.Shift(index);
					return index;
				}
            }
			throw new ArgumentException();
		}

	}
}
