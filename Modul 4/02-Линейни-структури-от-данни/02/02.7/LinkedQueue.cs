using System;
using System.Collections.Generic;
using System.Text;

namespace _02._7
{
    public class LinkedQueue<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; }

        ////////////////////////////////////////////////

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (this.Count == 0)
            {
                this.Head = newNode;
            }
            else
            {
                newNode.Prev = this.Tail;
                this.Tail.Next = newNode;
            }
            this.Tail = newNode;
            this.Count++;
        }
        public T Dequeue()
        {
            T element = this.Head.Item;

            this.Head = this.Head.Next;
            if(this.Head != null)
            {
                this.Head.Prev = null;
            }
            else
            {
                this.Tail = null;
            }
            this.Count--;

            return element;
        }
        public T Peek()
        {
            return this.Head.Item;
        }
        public T[] ToArray()
        {
            Node<T> current = this.Head;
            T[] array = new T[this.Count];
            int index = 0;

            while(current != null)
            {
                array[index] = current.Item;
                current = current.Next;
                index++;
            }
            return array;
        }
    }

    public class Node<T>
    {
        public T Item { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        public Node(T item)
        {
            this.Item = item;
        }
    }
}
