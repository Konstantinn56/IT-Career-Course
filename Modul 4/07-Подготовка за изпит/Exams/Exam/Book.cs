using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public class Book
    {
        private string id;
        private Book next;

        public Book(string id)
        {
            this.Id = id;
            this.Next = null;
        }

        public string Id
        {
            get { return id; }
            private set { id = value; }
        }
        public Book Next
        {
            get { return next; }
            set { next = value; }
        }

        public override string ToString()
        {
            return $"Book: {this.Id}";
        }
    }
}
