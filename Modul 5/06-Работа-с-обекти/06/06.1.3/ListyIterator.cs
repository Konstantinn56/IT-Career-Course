using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._1._3
{
    class ListyIterator<T>
    {
        private List<T> items;
        private int index;
        public ListyIterator(IEnumerable<T> collection)
        {
            this.items = new List<T>(collection);
        }

        public bool Move()
        {
            if (!HasNext())
            {
                return false;
            }
            this.index++;
            return true;
        }
        public bool HasNext()
        {
            if(this.index + 1 > this.items.Count - 1)
            {
                return false;
            }
            return true;
        }

        public void Print()
        {
            Console.WriteLine(this.items[index]);
        }
    }
}
