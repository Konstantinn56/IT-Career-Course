using System;
using System.Collections.Generic;
using System.Text;

namespace _02._6
{
    public class ListNode<T>
    {
        private T item;
        private ListNode<T> next;
        private ListNode<T> prev;

        public ListNode(T item)
        {
            this.Item = item;
            this.Next = null;
            this.Prev = null;
        }

        public T Item
        {
            get { return item; }
            set { item = value; }
        }
        public ListNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }
        public ListNode<T> Prev
        {
            get { return prev; }
            set { prev = value; }
        }
    }
}
