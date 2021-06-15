using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsSkeleton
{
    class Deque<T>
    {
        private T[] frontBuffer = new T[16];
        private T[] backBuffer = new T[16];

        public int BackCount { get; private set; }
        public int FrontCount { get; private set; }
        public int Count
        {
            get
            {
                return BackCount + FrontCount;
            }
        }

        public void AddBack(T item)
        {
            throw new NotImplementedException();
        }

        private void GrowBack()
        {
            throw new NotImplementedException();
        }



        public void AddFront(T item)
        {
            throw new NotImplementedException();
        }
        private void GrowFront()
        {
            throw new NotImplementedException();
        }

        public T GetFront()
        {
            throw new NotImplementedException();
        }

        public T GetBack()
        {
            throw new NotImplementedException();
        }

        public T RemoveBack()
        {
            throw new NotImplementedException();
        }

        public T RemoveFront()
        {
            throw new NotImplementedException();
        }
    }
}
