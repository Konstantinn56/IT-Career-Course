using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nb
{
    public class MyList<T> : IList<T> where T : IComparable<T>
    {
        private List<T> items = new List<T>();
        
        public void Add(T item)
        {
            this.items.Add(item);
        }

        public bool Contains(T element)
        {
            foreach (var item in this.items)
            {
                if (item.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public int CountGreaterThan(T element)
        {
            int counter = 0;
            foreach (var item in this.items)
            {
                if(item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public T Max()
        {
            return this.items.Max();
        }

        public T Min()
        {
            return this.items.Min();
        }

        public T Remove(int index)
        {
            T removedItem = this.items[index];
            this.items.RemoveAt(index);
            return removedItem;
        }

        public void Swap(int i1, int i2)
        {
            T item = this.items[i1];
            this.items[i1] = this.items[i2];
            this.items[i2] = item;
        }
    }
}
