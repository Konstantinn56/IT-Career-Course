using System;
using System.Collections.Generic;
using System.Text;

namespace _02._2_Ex2
{
    public class DynamicList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
            private set
            {
                count = value;
            }
        }

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        public T this[int index]
        {
            get
            {
                return this.GetNode(index).Element;
            }
            set
            {
                this.GetNode(index).Element = value;
            }
        }
        private Node<T> GetNode(int index)
        {
            int currentIndex = 0;
            Node<T> currentNode = this.head;
            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    return currentNode;
                }
                currentNode = currentNode.Next;
                currentIndex++;
            }
            throw new IndexOutOfRangeException();
        }
        public void Add(T item)
        {
            Node<T> newNode = null;
            if (this.Count == 0)
            {
                newNode = new Node<T>(item);
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode = new Node<T>(item, this.tail);
                this.tail = this.tail.Next;
            }
            this.Count++;
        }
        public T RemoveAt(int index)
        {
            Node<T> nodeToRemove = GetNode(index);
            Node<T> prev = null;
            Node<T> current = this.head;
            int currentIndex = 0;

            while (current != null)
            {
                if (currentIndex == index)
                {
                    if(prev == null)
                    {
                        this.head = current.Next;
                    }
                    else if(current.Next == null)
                    {
                        prev.Next = null;
                        this.tail = prev;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }
                    this.Count--;
                }
                prev = current;
                current = current.Next;
                currentIndex++;
            }
            return nodeToRemove.Element;
        }

        public int Remove(T item)
        {
            int index = this.IndexOf(item);

            if(index != -1)
            {
                Node<T> prev = null;
                Node<T> current = this.head;
                while (current != null)
                {
                    if (current.Element.Equals(item))
                    {
                        if(prev == null)
                        {
                            this.head = current.Next;
                        }
                        else if (current.Next == null)
                        {
                            prev.Next = null;
                            this.tail = prev;
                        }
                        else
                        {
                            prev.Next = current.Next;
                        }
                        this.Count--;
                    }
                    prev = current;
                    current = current.Next;
                }
            }

            return index;
        }
        public int IndexOf(T item)
        {
            int index = 0;
            Node<T> currentNode = this.head;
            while (currentNode != null)
            {
                if (currentNode.Element.Equals(item))
                {
                    return index;
                }
                currentNode = currentNode.Next;
                index++;
            }
            throw new IndexOutOfRangeException();
        }
        
        public bool Contains(T item)
        {
            Node<T> currentNode = this.head;
            while (currentNode != null)
            {
                if (currentNode.Element.Equals(item))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }
        

        

    }

    ///////////////////////////////////////////////////////////////////////////////////
    
    public class Node<T>
    {
        private T element;
        private Node<T> next;

        public T Element
        {
            get { return element; }
            set { element = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node(T element)
        {
            this.Element = element;
            this.Next = null;
        }
        public Node(T element , Node<T> tail)
        {
            this.Element = element;
            tail.Next = this;
        }
    }
}
