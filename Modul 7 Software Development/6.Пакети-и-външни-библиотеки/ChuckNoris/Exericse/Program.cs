using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Exericse
{
    internal class Program
    {
        public static void PrintSeparator()
        {
            Console.WriteLine(new string('-', 50));
        }
        static void Main(string[] args)
        {
            Product product = new Product(1, "Test product", 100.01m, 100, new DateTime(2019, 06, 30));
            string json = JsonConvert.SerializeObject(product);

            

            List<Product> products = new List<Product>()
            {
                new Product(1, "Test product", 100.01m, 100, new DateTime(2019, 06, 30)),
                new Product(2, "Test product", 100.01m, 100, new DateTime(2019, 06, 30)),
                new Product(3, "Test product", 100.01m, 100, new DateTime(2019, 06, 30)),
                new Product(4, "Test product", 100.01m, 100, new DateTime(2019, 06, 30))
            };
            string jsonList = JsonConvert.SerializeObject(products);
            Console.WriteLine(string.Join(Environment.NewLine, jsonList));

            PrintSeparator();

            //Deserialize a list of json data:
            string jsonSizes = @"['Smaall', 'Medium', 'Large']";
            JArray a = JArray.Parse(jsonSizes);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}