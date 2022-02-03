using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    public class StoreController
    {
        private List<Store> stores = new List<Store>();
        public string CreateStore(List<string> args)
        {
            Store store = new Store(args[0], args[1]);
            
            if (GetStore(store.Name) != null)
            {
                return $"Store {store.Name} is already registered!";
            }
            this.stores.Add(store);
            return $"Store {store.Name} was successfully registerd in the system!";
        }
        public string ReceiveProduct(List<string> args)
        {
            string storeName = args[5];
            Store store = GetStore(storeName);
            if (store == null)
            {
                return $"Invalid Store: {store.Name}. Cannot find it in system!";
            }
            else
            {
                Product product = null;
                switch (args[0])
                {
                    case ("Food"):
                        {
                            product = new Food(args[1], int.Parse(args[2]), double.Parse(args[3]), double.Parse(args[4]));
                            break;
                        }
                    case ("Drink"):
                        {
                            product = new Drink(args[1], int.Parse(args[2]), double.Parse(args[3]), double.Parse(args[4]));
                            break;
                        }
                    default:
                        {
                            return $"Product {args[0]} is invalid!";
                        }
                }
                if (store.ReceiveProduct(product))
                {
                    return $"Product {product.Name} was successfully delivered to {store.Name}!";
                }
                else
                {
                    return $"Product {product.Name} was already delivered to {store.Name}!";
                }
            }
            
        }
        public string SellProduct(List<string> args)
        {
            Store store = GetStore(args[2]);
            if (store == null)
            {
                return $"Invalid Store: {store.Name}. Cannot find it in system!";
            }
            if(store.SellProduct(args[0], int.Parse(args[1])))
            {
                return $"Product {args[0]} was successfully bought from {store.Name}!";
            }
            return $"Product {args[0]} was already sold out!";
        }
        public string StoreInfo(List<string> args)
        {
            Store store = GetStore(args[0]);
            if (store == null)
            {
                return $"Invalid Store: {args[0]}. Cannot find it in system!";
            }
            return store.ToString();
        }
        public string Shutdown()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Stores: {stores.Count}");
            foreach (Store store in stores.OrderByDescending(r => r.Revenue).ThenBy(s => s.Name))
            {
                sb.AppendLine();
                sb.Append(store.ToString());
            }
            sb.AppendLine();
            sb.Append($"System Store Revenues: {stores.Sum(r=> r.Revenue):f2}BGN");
            return sb.ToString();
        }
        public Store GetStore(string name)
        {
            return stores.Where(s => s.Name.Equals(name)).FirstOrDefault();
        }
    }
}
