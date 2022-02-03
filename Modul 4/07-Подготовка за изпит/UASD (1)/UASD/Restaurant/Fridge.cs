using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Fridge
    {
        private Product head;
        private Product tail;


        public int Count { get; private set; }

        public void AddProduct(string productName)
        {
            Product product = new Product(productName);
            if (this.Count == 0)
            {
                this.head = product;
            }
            else
            {
                this.tail.Next = product;
            }

            this.tail = product;
            this.Count++;
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            string[] allProducts = new string[this.Count];

            Product current = this.head;
            int index = 0;
            while (current != null)
            {
                allProducts[index] = current.ToString();
                current = current.Next;
                index++;
            }

            return allProducts;
        }

        public string RemoveProductByIndex(int index)
        {
            int currentIndex = 0;
            Product prevProduct = null;
            Product current = this.head;

            while (current != null)
            {
                if (currentIndex == index)
                {
                    if (prevProduct == null)
                    {
                        this.head = this.head.Next;
                    }
                    else
                    {
                        prevProduct.Next = current.Next;
                    }
                    if (current.Next == null)
                    {
                        this.tail = prevProduct;
                    }
                    this.Count--;
                    return current.Name;
                }
                else
                {
                    prevProduct = current;
                    current = current.Next;
                    currentIndex++;
                }
            }

            return null;
        }

        public string[] CookMeal(int startIndex, int endIndex)
        {
            string[] productNames = null;
            if (startIndex == 0)
            {
                if(endIndex >= this.Count)
                {
                    productNames = new string[this.Count];
                }
                else
                {
                    productNames = new string[endIndex + 1];
                }
            }
            else
            {
                if (endIndex >= this.Count)
                {
                    productNames = new string[this.Count];
                }
                else
                {
                    productNames = new string[endIndex];
                }
            }

            string[] allProducts = this.ProvideInformationAboutAllProducts();

            for (int i = startIndex, j=0; i < endIndex && i < allProducts.Length; i++, j++)
            {
                productNames[j] = allProducts[i].Replace("Product ", "");
            }

            return productNames;
        }

        public string RemoveProductByName(string name)
        {
            Product current = this.head;
            int index = 0;
            while (current != null)
            {
                if (current.Name.Equals(name))
                {
                    return this.RemoveProductByIndex(index);
                }
                current = current.Next;
                index++;
            }

            return null;
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
