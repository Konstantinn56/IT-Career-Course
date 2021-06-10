using System;
using System.Collections.Generic;
using System.Text;

namespace _02._7
{
    public class LinkedQueue<T>
    {
        public int Count { get; set; }
        public QueueNode<T> Head { get; set; }
        public QueueNode<T> Tail { get; set; }

        public LinkedQueue()
        {
            this.Head = null;
            this.Tail = null;
        }

        public void Enqueue(T element)
        {
            QueueNode<T> newNode = new QueueNode<T>(element);
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
            T element = this.Head.Element;

            this.Head = this.Head.Next;
            if (this.Head == null)
            {
                this.Tail = null;
            }
            else
            {
                this.Head.Prev = null;
            }
            this.Count--;
            return element;
        }

  
    }
    public class QueueNode<T>
    {
        public T Element { get; set; }
        public QueueNode<T> Next { get; set; }
        public QueueNode<T> Prev { get; set; }

        public QueueNode(T item)
        {
            this.Element = item;
            this.Next = null;
            this.Prev = null;
        }
    }
}
