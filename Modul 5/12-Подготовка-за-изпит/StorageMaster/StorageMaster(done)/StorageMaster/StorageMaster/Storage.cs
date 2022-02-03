using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster
{
    public abstract class Storage
    {
        private string name;
        private int capacity;
        private int garageSlots;
        private Vehicle[] garage;
        private List<Product> products;

        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            garage = new Vehicle[this.GarageSlots];
            for (int i = 0; i < Math.Min(this.GarageSlots, vehicles.Count()); i++)
            {
                this.garage[i] = vehicles.ToArray()[i];
            }

            this.products = new List<Product>();
        }
        

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }
        public int GarageSlots
        {
            get { return garageSlots; }
            private set { garageSlots = value; }
        }

        public IReadOnlyCollection<Vehicle> Garage { get => this.garage; }

        public IReadOnlyCollection<Product> Products { get => this.products; }

        public bool IsFull
        {
            get 
            {
                return this.products.Sum(p => p.Weight) >= this.Capacity;
            }
        }

        public Vehicle GetVehicle(int garageSlot)
        {
            if(garageSlot >= this.GarageSlots || garageSlot < 0)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            if(this.garage[garageSlot] == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return this.garage[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);
            if(deliveryLocation.Garage.Where(s => s == null).Count() <= 0)
            {
                throw new InvalidOperationException("No room in garage!");
            }

            this.garage[garageSlot] = null;
            int freeGarageSlot = -1;

            for (int i = 0; i < deliveryLocation.Garage.Count; i++)
            {
                if (deliveryLocation.garage[i] == null)
                {
                    deliveryLocation.garage[i] = vehicle;
                    freeGarageSlot = i;
                    break;
                }
            }

            return freeGarageSlot;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            Vehicle vehicle = this.GetVehicle(garageSlot);
            int unloadedProductsCount = 0;

            while (!vehicle.IsEmpty && !this.IsFull)
            {
                Product product = vehicle.Unload();
                this.products.Add(product);
                unloadedProductsCount++;
            }

            return unloadedProductsCount;
        }
    }
}
