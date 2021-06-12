using System;
using System.Collections.Generic;
using System.Text;

namespace _02._8
{
    public class LinkedStack<T>
    {
        private Node<T> head;
        public int Count { get; private set; }

        public LinkedStack()
        {
            this.head = null;
            this.Count = 0;
        }



        public void Push(T element)
        {
            Node<T> elementToAdd = new Node<T>(element);
            if (this.Count == 0)
            {
                this.head = elementToAdd;
            }
            else
            {
                elementToAdd.Next = this.head;
                this.head = elementToAdd;
            }
            this.Count++;
        }

        public T Pop()
        {
            T elementToRemove = this.head.Value;
            if(this.Count == 0)
            {
                throw new InvalidOperationException();
            }
            this.head = this.head.Next;
            this.Count--;
            return elementToRemove;
        }
        public T[] ToArray()
        {
            T[] result = new T[this.Count];
            Node<T> current = this.head;
            for (int i = 0; i < this.Count; i++)
            {
                result[i] = current.Value;
                current = current.Next;
            }
            return result;
        }
        
        /////////////////////////////////////////////////////////////////////////
        
        private class Node<T>
        {
            private T value;
            public Node<T> Next { get; set; }
            public T Value
            {
                get
                {
                    return value;
                }
                set
                {
                    value = value;
                }
            }
            public Node(T value)
            {
                this.value = value;
                this.Next = null;
            }
        }

    }
    
}
