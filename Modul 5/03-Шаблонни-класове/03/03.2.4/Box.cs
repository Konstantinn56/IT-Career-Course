using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._2._4
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public int Count => this.data.Count;

        public void Add(T item)
        {
            this.data.Add(item);
        }
        public T Remove()
        {
            T result = this.data.LastOrDefault();
            this.data.RemoveAt(this.data.Count - 1);
            return result;
        }

        public int Compare(T c)
        {
            int count = 0;
            foreach (var item in data)
            {
                if(item.CompareTo(c) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.data)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }
            return sb.ToString();
        }
    }
}
