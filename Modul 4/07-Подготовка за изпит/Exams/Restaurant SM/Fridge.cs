using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_SM
{
    public class Fridge
    {
        private Product head;
        private Product tail;

        public Fridge()
        {
            this.Head = this.Tail = null;
            this.Count = 0;
        }

        public Product Head
        {
            get { return head; }
            set { head = value; }
        }
        public Product Tail
        {
            get { return tail; }
            set { tail = value; }
        }
        public int Count { get; set; }

        public void AddProduct(string name)
        {
            Product newProduct = new Product(name);
            if(this.Count == 0)
            {
                this.Head = newProduct;
            }
            else
            {
                this.Tail.Next = newProduct;
            }
            this.Tail = newProduct;
            this.Count++;
        }
        public string[] ProvideInformationAboutAllProducts()
        {
            string[] result = new string[this.Count];
            Product current = this.Head;
            int index = 0;
            while (current != null)
            {
                result[index] = current.ToString();
                current = current.Next;
                index++;
            }
            return result;
        }
        public string RemoveProductByIndex(int index)
        {
            if (this.Count == 0 || this.Count < index)
            {
                throw new IndexOutOfRangeException();
            }
            Product current = this.Head;
            string toRemove = null;
            int i = 0;
            while (current != null)
            {
                if(i == index)
                {
                    toRemove = current.Name;
                }
                i++;
                current = current.Next;
            }
            return RemoveProductByName(toRemove);
        }
        public string RemoveProductByName(string name)
        {
            if (this.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Product toRemove = null;
                Product prev = null;
                Product current = this.Head;
                while (current != null)
                {
                    if (current.Name.Equals(name))
                    {
                        toRemove = current;
                        if (this.Count == 1)
                        {
                            this.Head = this.Tail = null;
                            break;
                        }
                        else if(current == this.Head)
                        {
                            this.Head = this.Head.Next;
                            break;
                        }
                        else if (current == this.Tail)
                        {
                            this.Tail = prev;
                            this.Tail.Next = null;
                            break;
                        }
                        else
                        {
                            prev.Next = current.Next;
                            break;
                        }
                    }
                    prev = current;
                    current = current.Next;
                }
                this.Count--;
                return toRemove.Name;
            }
        }
        public bool CheckProductIsInStock(string name)
        {
            Product current = this.Head;
            while (current != null)
            {
                if (current.Name.Equals(name))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public string[] CookMeal(int startIndex, int endIndex)
        {
            List<string> products = new List<string>();
            int index = 0;
            Product current = this.Head;
            while ( current != null)
            {
                if(index == startIndex)
                {
                    for (int i = 0; i <= endIndex; i++)
                    {
                        products.Add(current.Name);
                        current = current.Next;
                        if(current == null)
                        {
                            return products.ToArray();
                        }
                    }
                }
                current = current.Next;
                index++;
            }
            return products.ToArray();

        }

    }
}
