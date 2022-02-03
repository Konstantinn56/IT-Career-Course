using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Train
{
    public class Deque<T> where T : Train
    {
		private const int defaultCapacity = 16;
		public int Capacity; 
		public int Count;
		private Stack<Train> pTrains;
		private Stack<Train> fTrains;
		private Stack<Train> history;

		public Deque() : this(defaultCapacity)
		{

		}
		public Deque(int capacity)
		{
			this.Capacity = capacity;
			this.pTrains = new Stack<Train>(this.Capacity);
			this.fTrains = new Stack<Train>(this.Capacity);
			this.history = new Stack<Train>(this.Capacity);
		}
		public Deque(IEnumerable<T> collection) : this(collection.Count())
		{
            foreach (var train in collection)
            {
                if (train.Type.Equals("P"))
                {
					this.pTrains.Push(train);
                }
                else if(train.Type.Equals("F"))
                {
					this.fTrains.Push(train); 
                }
            }
		}
		
		public void AddFront(T item)
		{
			this.pTrains.Push(item);
			this.Count++;
		}
		public void AddBack(T item)
		{
			this.fTrains.Push(item);
			this.Count++;
		}
		public T RemoveFront()
		{
			if(this.pTrains.Count > 0)   
            {
				this.history.Push(this.pTrains.Peek());
				this.Count--;
				return (T)this.pTrains.Pop();
            }
			return default;
		}
		public T RemoveBack()
		{
			if (this.fTrains.Count > 0)
			{
				this.history.Push(this.fTrains.Peek());
				this.Count--;
				return (T)this.fTrains.Pop();
			}
			return default;
		}
		public T GetFront()
		{
            if (this.pTrains.Any())
            {
				return (T)this.pTrains.Peek();
			}
			return default;
		}
		public T GetBack()
		{
			if (this.fTrains.Any())
			{
				return (T)this.fTrains.Peek();
			}
			return default;
		}

		public void GetHistory()
        {
            if (this.history.Any())
            {
				foreach (var item in this.history)
				{
					Console.WriteLine(item.ToString());
				}
			}
        }

	}

}

