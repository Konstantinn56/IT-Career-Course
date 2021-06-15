using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deque
{
    class Deque<T>
    {
        private T[] frontBuffer = new T[16];
        private T[] backBuffer = new T[16];

        public int BackCount { get; private set; }
        public int FrontCount { get; private set; }
        public int Count {
            get
            {
                return BackCount + FrontCount;
            }
        }
        
        public void AddBack(T item)
        {
            if (this.BackCount == this.backBuffer.Length)
            {
                GrowBack();
            }
            this.backBuffer[this.BackCount] = item;
            this.BackCount++;
        }

        private void GrowBack()
        {
            T[] newBuffer = new T[backBuffer.Length * 2];
            backBuffer.CopyTo(newBuffer, 0);
            backBuffer = newBuffer;
        }



        public void AddFront(T item)
        {
            if (this.FrontCount == this.frontBuffer.Length)
            {
                GrowFront();
            }
            this.frontBuffer[this.FrontCount] = item;
            this.FrontCount++;
        }
        private void GrowFront()
        {
            T[] newBuffer = new T[frontBuffer.Length * 2];
            frontBuffer.CopyTo(newBuffer, 0);
            frontBuffer = newBuffer;
        }

        public T GetFront()
        {
            if (0 == this.FrontCount)
            {
                return default(T);
            }

            T result = frontBuffer[this.FrontCount-1];
            return result;
        }

        public T GetBack()
        {
            if (0 == this.BackCount)
            {
                return default(T);
            }

            T result = backBuffer[this.BackCount - 1];
            return result;
        }

        public T RemoveBack()
        {
            if (0 == this.BackCount)
            {
                throw new InvalidOperationException("The Deque is empty");
            }

            int endIndex = this.BackCount - 1;
            T result = backBuffer[endIndex];
            backBuffer[endIndex] = default(T);
            this.BackCount--;

            return result;

        }

        public T RemoveFront()
        {
            if (0 == this.FrontCount)
            {
                throw new InvalidOperationException("The Deque is empty");
            }

            int endIndex = this.FrontCount - 1;
            T result = frontBuffer[endIndex];
            frontBuffer[endIndex] = default(T);
            this.FrontCount--;

            return result;
        }
    }
}
