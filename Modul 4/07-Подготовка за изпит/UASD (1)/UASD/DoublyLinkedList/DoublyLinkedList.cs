using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListDemo
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public class Node<T>
        {
            public T Item { get; set; }
            public Node<T> PrevNode { get; set; }
            public Node<T> NextNode { get; set; }

            public Node(T item)
            {
                this.Item = item;
            }
        }

        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; }

        public void AddFirst(T item)
        {
            Node<T> newHead = new Node<T>(item);
            if(this.Count == 0)
            {
                this.Head = newHead;
                this.Tail = newHead;
            }
            else
            {
                newHead.NextNode = this.Head;
                this.Head.PrevNode = newHead;
                this.Head = newHead;
            }

            this.Count++;
        }

        public void AddLast(T item)
        {
            Node<T> newTail = new Node<T>(item);

            if(this.Count == 0)
            {
                this.Head = newTail;
                this.Tail = newTail;
            }
            else
            {
                newTail.PrevNode = this.Tail;
                this.Tail.NextNode = newTail;
                this.Tail = newTail;
            }
            this.Count++;
        }

        public T RemoveFirst()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }

            T removed = this.Head.Item;
            this.Head = this.Head.NextNode;

            if(this.Head == null)
            {
                this.Tail = null;
            }
            else
            {
                this.Head.PrevNode = null;
            }

            this.Count--;
            return removed;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }

            T removed = this.Tail.Item;
            this.Tail = this.Tail.PrevNode;

            if(this.Tail == null)
            {
                this.Head = null;
            }
            else
            {
                this.Tail.NextNode = null;
            }

            this.Count--;
            return removed;
        }

        public void ForEach(Action<T> action)
        {
            Node<T> current = this.Head;

            while(current != null)
            {
                action(current.Item);
                current = current.NextNode;
            }
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            int index = 0;

            Node<T> current = this.Head;
            while (current != null)
            {
                array[index] = current.Item;
                current = current.NextNode;
                index++;
            }

            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = this.Head;
            while(current != null)
            {
                yield return current.Item;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
