using System;
using System.Collections.Generic;
using System.Text;

namespace _02._2_DynamicList
{
    public class DynamicList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public int Count { get; set; }


        public void Add(T item)
        {
            Node<T> newNode = null;
            if (this.Count == 0)
            {
                newNode = new Node<T>(item);
                this.Head = new Node<T>(item);
            }
            else
            {
                newNode = new Node<T>(item, this.Tail);
            }
            this.Tail = newNode;
            this.Count++;
            
        }

        public int IndexOf(T item)
        {
            int index = -1;

            Node<T> current = this.Head;

            while (current != null)
            {
                index++;
                if (item.Equals(current.Element))
                {
                    return index;
                }
                
                current = current.Next;
            }

            return index;
        }
    }
    /// /////////////////////////////////////////////////////////
    public class Node<T>
    {
        public T Element { get; set; }
        public Node<T> Next { get; set; }

        public  Node(T element)
        {
            this.Element = element;
            this.Next = null;
        }
        public Node(T element, Node<T> tail)
        {
            this.Element = element;
            tail.Next = this;
        }
    }
}
