using System;
using System.Collections.Generic;
using System.Text;

namespace _02._8
{
    public class LinkedStack<T>
    {
        public int Count { get; set; }
        public Node<T> firstNode { get; set; }
        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item, firstNode);
            this.firstNode = newNode;
            this.Count++;
        }
        public T Pop()
        {
            T item = this.Peek();
            this.firstNode = firstNode.Next;
            this.Count--;
            return item;
        }
        public T Peek()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("...");
            }
            return this.firstNode.Item;
        }

        public T[] ToArray()
        {
            Node<T> current = this.firstNode;
            T[] array = new T[this.Count];
            int index = 0;
            while(current != null)
            {
                array[index] = current.Item;
                index++;
                current = current.Next;
            }
            return array;
        }
    }

    public class Node<T>
    {
        public T Item { get; set; }
        public Node<T> Next { get; set; }

        public Node(T item, Node<T> nextNode = null)
        {
            this.Item = item;
            this.Next = nextNode;
        }
    }
}
