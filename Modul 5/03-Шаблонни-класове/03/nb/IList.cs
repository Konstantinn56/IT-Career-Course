using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nb
{
    interface IList<T>
    {
        void Add(T item);
        T Remove(int index);
        bool Contains(T element);
        void Swap(int i1, int i2);
        int CountGreaterThan(T item);
        T Min();
        T Max();
    }
}
