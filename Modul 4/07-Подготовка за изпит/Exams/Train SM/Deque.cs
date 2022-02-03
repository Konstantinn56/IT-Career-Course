using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Train_SM
{
	public class Deque<T> where T : Train
	{
		private const int defaultCapacity = 16;
		public int Capacity; //показва капацитета
		public int Count; //показва броят елементи
		private Stack<Train> pTrains;
		private Stack<Train> fTrains;
		private Stack<Train> history;




		public Deque() : this(defaultCapacity)
		{
		}
		public Deque(int capacity)
		{
			this.Capacity = capacity;
			this.pTrains = new Stack<Train>(capacity);
			this.fTrains = new Stack<Train>(capacity);
			this.history = new Stack<Train>(capacity);
		}
		public Deque(IEnumerable<T> collection)
				: this(collection.Count())
		{
			//създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека
		}
		public void AddFront(T item)
		{
			//добавя елемент отпред
		}
		public void AddBack(T item)
		{
			//добавя елемент отзад
		}
		public T RemoveFront()
		{
			//връща и премахва елемента отпред
		}
		public T RemoveBack()
		{
			//връща и премахва елемента отзад
		}
		public T GetFront()
		{
			//връща, без да премахва, елемента отпред
		}
		public T GetBack()
		{
			//връща, без да премахва, елемента отзад
		}
	}

}
