using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public class Shelf
    {
        private Book head;
        private Book tail;
        private int count;
        public Shelf()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        public Book Head
        {
            get { return head; }
            private set { head = value; }
        }
        public Book Tail
        {
            get { return tail; }
            private set { tail = value; }
        }
        public int Count 
        {
            get { return count; }
            private set { count = value; }
        }

        public void AddBook(string bookId)
        {
            Book newBook = new Book(bookId);
            if(this.Count == 0)
            {
                this.Head = newBook;
                this.Tail = newBook;
            }
            else
            {
                this.Tail.Next = newBook;
                this.Tail = newBook;
            }
            this.Count++;
        }
        public StringBuilder ShelfInformation()
        {
            StringBuilder sb = new StringBuilder();
            if(this.Count == 0)
            {
                sb.AppendLine("Shelf is empty!");
                return sb;
            }
            Book current = this.Head;
            while (current != null)
            {
                sb.AppendLine(current.ToString());
                current = current.Next;
            }
            return sb;
        }
        public bool ReleaseBook(string bookId)
        {
            if(this.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            Book current = this.Head;
            Book prev = null;
            while (current != null)
            {
                if (current.Id.Equals(bookId))
                {
                    if(this.Count == 1)
                    {
                        this.Head = this.Tail = null;
                    }
                    else if (this.Head == current)
                    {
                        this.Head = this.Head.Next;
                    }
                    else if(this.Tail == current)
                    {
                        this.Tail = prev;
                        this.Tail.Next = null;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }
                    this.Count--;
                    return true;
                }
                prev = current;
                current = current.Next;
            }
            return false;
        }
        public bool ReleaseBook(int v)
        {
            if(v < 0 || this.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            int index = 0;
            Book current = this.Head;
            while (current != null)
            {
                if (index == v)
                {
                    return ReleaseBook(current.Id);
                }
                current = current.Next;
                index++;
            }
            return false;
        }
        public Book CheckBookIsPresent(string bookId)
        {
            Book current = this.Head;
            while (current != null)
            {
                if (current.Id.Equals(bookId))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void AddSpecialBook(string bookId)
        {
            Book newBook = new Book(bookId);
            newBook.Next = this.Head;
            this.Head = newBook;
            this.Count++;
        }

        

        

        
    }
}
