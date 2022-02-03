using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster
{
    public class StorageMaster
    {
        private List<Product> products;
        private List<Storage> storages;
        private Vehicle vehicle = null;
        public StorageMaster()
        {
            this.products = new List<Product>();
            this.storages = new List<Storage>();
        }
        public string AddProduct(string type, double price)
        {
            Product product = null;
            switch (type)
            {
                case "Gpu":
                    product = new Gpu(price);
                    break;
                case "HardDrive":
                    product = new HardDrive(price);
                    break;
                case "Ram":
                    product = new Ram(price);
                    break;
                case "SolidStateDrive":
                    product = new SolidStateDrive(price);
                    break;
                default:
                    throw new InvalidOperationException("Invalid product type!");
            }

            this.products.Add(product);

            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = null;

            switch (type)
            {
                case "AutomatedWarehouse":
                    storage = new AutomatedWarehouse(name);
                    break;
                case "DistributionCenter":
                    storage = new DistributionCenter(name);
                    break;
                case "Warehouse":
                    storage = new Warehouse(name);
                    break;
                default:
                    throw new InvalidOperationException("Invalid storage type!");

            }

            this.storages.Add(storage);

            return $"Registered {name}";
            
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.GetStorageByName(storageName);
            if(storage != null)
            {
                vehicle = storage.GetVehicle(garageSlot);
            }

            return $"Selected {vehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int loadedProductsCount = 0;

            for (int i = 0; i < productNames.Count(); i++)
            {
                Product product = this.products
                    .Where(p => p.GetType().Name.Equals(productNames.ToArray()[i]))
                    .LastOrDefault();

                if(product == null)
                {
                    throw new InvalidOperationException($"{productNames.ToArray()[i]} is out of stock!");
                }
                this.products.Remove(product);
                vehicle.LoadProduct(product);
                loadedProductsCount++;
            }

            return $"Loaded {loadedProductsCount}/{productNames.Count()} products into {this.vehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            Storage sourceStorage = this.GetStorageByName(sourceName);
            if(sourceStorage == null)
            {
                throw new InvalidOperationException("Invalid source storage!");
            }

            Storage destinationStorage = this.GetStorageByName(destinationName);
            if(destinationStorage == null)
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }

            int destinationGarageSlot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);

            return $"Sent {destinationStorage.GetVehicle(destinationGarageSlot).GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.GetStorageByName(storageName);
            int productsInVehicle = storage.GetVehicle(garageSlot).Trunk.Count();

            int unloadedProductsCount = storage.UnloadVehicle(garageSlot);

            return $"Unloaded {unloadedProductsCount}/{productsInVehicle} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            StringBuilder sb = new StringBuilder();
            Storage storage = this.GetStorageByName(storageName);

            Dictionary<string, List<Product>> dict = new Dictionary<string, List<Product>>();
           
            foreach (var product in storage.Products)
            {
                if (!dict.ContainsKey(product.GetType().Name))
                {
                    dict.Add(product.GetType().Name, new List<Product>());
                }

                dict[product.GetType().Name].Add(product);
            }

            Dictionary<string, List<Product>> productsOrdered = dict.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key).ToDictionary(x => x.Key, y=>y.Value) ;

            sb.Append($"Stock ({storage.Products.Sum(p => p.Weight)}/{storage.Capacity}): [");

            sb.Append($"{string.Join(", ", productsOrdered.Select(x => x.Key + $" ({x.Value.Count})").ToArray())}");
            
            
            sb.AppendLine("]");
            //Garage: [Semi|Semi|Semi|Van|empty|empty|empty|empty|empty|empty]
            sb.Append($"Garage: [");

            
            foreach (var item in storage.Garage)
            {
                if(item == null)
                {
                    sb.Append($"empty|");
                    continue;
                }
                sb.Append($"{item.GetType().Name}|");
            }
            sb.Remove(sb.Length-1, 1);
            sb.Append("]");
            return sb.ToString();
        }

        public string GetSummary()
        {
            StringBuilder sb = new StringBuilder();
            var allStorages = this.storages
                .OrderByDescending(s => s.Products.Sum(p => p.Price));
            foreach (var item in allStorages)
            {
                sb.AppendLine($"{item.Name}:");
                sb.Append("Storage worth: ");
                sb.AppendLine($"${item.Products.Sum(p=> p.Price):F2}");
            }
            return sb.ToString();
        }

        private Storage GetStorageByName(string storageName)
        {
            return this.storages.Where(s => s.Name.Equals(storageName)).FirstOrDefault();
        }
    }
}
