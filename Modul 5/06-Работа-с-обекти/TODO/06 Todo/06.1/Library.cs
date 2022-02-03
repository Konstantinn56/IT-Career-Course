using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._1
{
    class Library : IEnumerable<Book>
    {

        public List<Book> Books { get; set; }

        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in this.Books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
    public class LibraryIterator : IEnumerator<Book>
    {
        public List<Book> Books { get; set; }
        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.Books = new List<Book>(books);
        }

        public Book Current => this.Books[currentIndex];

        object IEnumerator.Current => this.Current;

       

        public bool MoveNext()
        {
            if(this.currentIndex < this.Books.Count - 1)
            {
                this.currentIndex++;
                return true;
            }
            return false;

        }

        public void Reset()
        {
            this.currentIndex = -1;
        }

        public void Dispose() { }
        
    }
}
