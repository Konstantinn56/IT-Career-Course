using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicListDemo
{
    public class DynamicList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; }

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is outside of the list");
                }

                int currentIndex = -1;

                Node<T> current = this.Head;

                while (current != null)
                {
                    currentIndex++;
                    if (index == currentIndex)
                    {
                        return current.Element;
                    }

                    current = current.Next;
                }

                return current.Element;
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index is outside of the list");
                }
                int currentIndex = -1;

                Node<T> current = this.Head;

                while (current != null)
                {
                    currentIndex++;
                    if (index == currentIndex)
                    {
                        current.Element = value;
                    }

                    current = current.Next;
                }

            }
        }
        public void Add(T item)
        {
            Node<T> newNode = null;

            if(this.Count == 0)//this.Head == null
            {
                newNode = new Node<T>(item);
                this.Head = newNode;                
            }
            else
            {
                newNode = new Node<T>(item, this.Tail);
            }

            this.Tail = newNode;
            this.Count++;
        }

        public T RemoveAt(int index)
        {
            int currentIndex = -1;

            Node<T> current = this.Head;

            Node<T> removed = current;

            while (current != null)
            {
                currentIndex++;
                if(index == currentIndex)
                {
                    this.Remove(current.Element);
                    break;
                }

                current = current.Next;
                removed = current;
            }

            return removed.Element;
        }

        public int Remove(T item)
        {
            int index = this.IndexOf(item);

            if(index != -1)
            {
                Node<T> prev = null;
                Node<T> current = this.Head;

                while(current != null)
                {
                    if (current.Element.Equals(item))
                    {
                        if (prev == null)
                        {
                            this.Head = current.Next;
                        }
                        else if (current.Next == null)
                        {
                            this.Tail = prev;
                            this.Tail.Next = null;
                        }
                        else
                        {
                            prev.Next = current.Next;
                        }

                        this.Count--;

                        return index;
                    }

                    prev = current;
                    current = current.Next;
                }
            }

            return index;
        }

        public bool Contains(T item)
        {
            return this.IndexOf(item) != -1 ? true : false;
        }
        public int IndexOf(T item)
        {
            int index = -1;

            Node<T> current = this.Head;

            while(current != null)
            {
                index++;

                if (item.Equals(current.Element))
                {
                    return index;
                }

                current = current.Next;
            }

            return -1;
        }
    }

    public class Node<T>
    {
        public T Element { get; set; }
        public Node<T> Next { get; set; }

        public Node(T element)
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
