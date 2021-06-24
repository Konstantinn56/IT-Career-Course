using System;
using System.Collections.Generic;
using System.Text;

namespace Restauranttt
{
    public class Fridge
    {
        private Product head;
        private Product tail;
        public int Count { get; private set; }

        public Fridge()
        {

        }
        
        public void AddProduct(string name)
        {
            Product newProduct = new Product(name);
            if(this.Count == 0)
            {
                this.head = newProduct;
            }
            else
            {
                this.tail.Next = newProduct;
            }
            this.tail = newProduct;
            this.Count++;
        }
        public string[] ProvideInformationAboutAllProducts()
        {
            Product current = this.head;
            string[] result = new string[this.Count];
            int index = 0;
            while (current != null)
            {
                result[index] = current.ToString();
                index++;
                current = current.Next;
            }
            return result;
        }

        public string RemoveProductByIndex(int index)
        {
            int currentIndex = 0;
            Product current = this.head;
            Product prev = null;
            while (current != null)
            {
                if(currentIndex == index)
                {
                    string result = current.Name;
                    if (this.head == current)
                    {
                        this.head = this.head.Next;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }
                    if(current.Next == null)
                    {
                        this.tail = prev;
                    }
                    return result;
                    
                }
                else
                {
                    currentIndex++;
                    prev = current;
                    current = current.Next;
                }
                
                
            }
            return null;
        }

        public string[] CookMeal(int startIndex, int endIndex)
        {
            string[] productNemes = null;
            if (startIndex == 0)
            {
                productNemes = new string[endIndex - 1];
            }
            else
            {
                productNemes = new string[endIndex];
            }
            string[] allProducts = this.ProvideInformationAboutAllProducts();
            for (int i = startIndex,j=0; i < endIndex || i < allProducts.Length; i++,j++)
            {
                productNemes[j] = allProducts[startIndex];
            }
            return productNemes;
             
        }

        public string RemoveProductByName(string name)
        {
            Product current = this.head;
            int currentIndex = 0;
            int indexToRemove = 0;
            while (current != null)
            {
                if (current.Name.Equals(name))
                {
                    indexToRemove = currentIndex;
                }
                currentIndex++;
                current = current.Next;
            }
            return RemoveProductByIndex(indexToRemove);
        }
        public bool CheckProductIsInStock(string name)
        {
            Product current = this.head;
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
    }
}
