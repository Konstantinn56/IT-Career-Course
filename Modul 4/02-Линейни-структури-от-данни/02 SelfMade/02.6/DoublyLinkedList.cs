using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02._6
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;
        public int Count { get; set; }
        public DoublyLinkedList()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        public ListNode<T> Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListNode<T> Tail
        {
            get { return tail; }
            set { tail = value; }
        }
        

        ///////////////////////////////////////////////////////////////////////////

        public void AddFirst(T element)
        {
            ListNode<T> nodeToAdd = new ListNode<T>(element);
            if (this.Head == null && this.Tail == null)
            { 
               
                this.Head = nodeToAdd;
                this.Tail = nodeToAdd;
            }
            else
            {
                nodeToAdd.Next = this.Head;
                this.Head.Prev = nodeToAdd;
                this.Head = nodeToAdd;
            }
            this.Count++;
        }
        //public void ForEach(Action<T> action)
        //{
        //    ListNode<T> currentNode = this.Head;
        //    while (currentNode != null)
        //    {
        //        action(currentNode.Item);
        //        currentNode = currentNode.Next;
        //    }
        //}
        public void AddLast(T element)
        {
            ListNode<T> nodeToAdd = new ListNode<T>(element);
            if(this.Tail == null)
            {
                this.Head = this.Tail = nodeToAdd;
            }
            else
            {
                nodeToAdd.Prev = this.Tail;
                this.Tail.Next = nodeToAdd;
                this.Tail = nodeToAdd;
            }
            this.Count++;
        }
        public T RemoveFirst()
        {
            T elementToRemove = this.Head.Item;
            if(this.Head == null && this.Tail == null)//empty list
            {
                throw new ArgumentException();
            }
            else if (this.Head == this.Tail)//one element
            {
                this.Head = null;
                this.Tail = null;
            }
            else
            {
                this.Head = this.Head.Next;
                this.Head.Prev = null;
            }

            this.Count--;
            return elementToRemove;
        }
        public T RemoveLast()
        {
            T elementToRemove = this.Tail.Item;
            if(this.Head == null && this.Tail == null)
            {
                throw new ArgumentException();
            }
            else if (this.Head == this.Tail)
            {
                this.Head = null;
                this.Tail = null;
            }
            else
            {
                this.Tail = this.Tail.Prev;
                this.Tail.Next = null;
            }
            this.Count--;
            return elementToRemove;
        }
        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            ListNode<T> currentNode = this.Head;
            for (int i = 0; i < this.Count; i++)
            {
                arr[i] = currentNode.Item;
                currentNode = currentNode.Next;
            }
            return arr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListNode<T> currentNode = this.Head;
            while (currentNode != null)
            {
                yield return currentNode.Item;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
