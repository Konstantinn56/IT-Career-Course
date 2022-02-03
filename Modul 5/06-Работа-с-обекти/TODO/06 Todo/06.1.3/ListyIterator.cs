using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._1._3
{
    public class ListyIterator<T>: IEnumerable<T>
    {
        private List<T> elements;
        private int currentIndex;
        public List<T> Elements
        {
            get { return elements; }
            private set { elements = value; }
        }

        public void Create(T[] input)
        {
            this.Elements = new List<T>();
            foreach (var e in input)
            {
                this.Elements.Add(e);
            }
            this.currentIndex = 0;
        }
        public bool Move()
        {
            if (HasNext())
            {
                this.currentIndex++;
                return true;
            }
            return false;
        }
        public void Print()
        {
            Console.WriteLine(this.Elements[currentIndex]);
        }
        public bool HasNext()
        {
            if(this.currentIndex < this.Elements.Count - 1)
            {
                return true;
            }
            return false;
        }
        public void PrintAll()
        {
            foreach (var item in this.Elements)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Elements.Count; i++)
            {
                yield return this.Elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
