using System;
using System.Collections.Generic;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split('=',';');
            string[] productInfo = Console.ReadLine().Split('=',';');

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            for (int i = 0; i < personInfo.Length - 1; i+=2)
            {
                string name = personInfo[i];
                double money = double.Parse(personInfo[i + 1]);
                Person person = new Person(name, money);
                people.Add(person);
            }
            for (int i = 0; i < productInfo.Length - 1; i+=2)
            {
                string name = productInfo[i];
                double price = double.Parse(productInfo[i + 1]);
                Product product = new Product(name,price);
                products.Add(product);
            }

            string[] buyingInfo = Console.ReadLine().Split();
            while (!buyingInfo[0].Equals("END"))
            {
                string name = buyingInfo[0];
                string pName = buyingInfo[1];

                foreach (var p in people)
                {
                    if (p.Name.Equals(name))
                    {
                        foreach (var pp in products)
                        {
                            if (pp.PName.Equals(pName))
                            {
                                p.TryBuyProduct(pp);
                            }
                        }
                    }
                }
                buyingInfo = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(Environment.NewLine,people));
            

        }
    }
}
