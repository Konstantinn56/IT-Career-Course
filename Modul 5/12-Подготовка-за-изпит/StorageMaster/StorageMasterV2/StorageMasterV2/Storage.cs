using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMasterV2
{
    public abstract class Storage
    {
        private string name;
        private int garageSlots;
        private Vehicle[] garage;
        private List<Product> products;
        ////////////////////////////////////////////////////////////////////////////
        
        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.garage = new Vehicle[this.garageSlots];
            for (int i = 0; i < Math.Min(this.GarageSlots , vehicles.Count()); i++)
            {
                this.garage[i] = vehicles.ToArray()[i];
            }
            this.products = new List<Product>();
        }
        ////////////////////////////////////////////////////////////////////////////
        
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int GarageSlots
        {
            get { return garageSlots; }
            private set { garageSlots = value; }
        }
        public int Capacity { get; private set; }
        public bool IsFull 
        {
            get {return this.Products.Sum(p => p.Weight) >= this.Capacity; }
        }
        public IReadOnlyCollection<Vehicle> Garage
        {
            get { return this.garage; }
        }
        public IReadOnlyCollection<Product> Products
        {
            get {  return this.products; }
        }
        ////////////////////////////////////////////////////////////////////////////
        
        public Vehicle GetVehicle(int gSlot)
        {
            if(gSlot >= this.GarageSlots || gSlot < 0)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }//throwing exception|No such a gSlot
            if (this.garage[gSlot].IsEmpty)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }//throwing exception|Garage empty
            return this.garage[gSlot];
        }
        public int SendVehicleTo(int gSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = GetVehicle(gSlot);
            if(this.GarageSlots == this.garage.Count())
            {
                throw new InvalidOperationException("No room in garage!");
            }//throwing exception| Garage Full
            this.garage[gSlot] = null;
            int index = -1;
            for (int i = 0; i < deliveryLocation.garage.Count(); i++)
            {
                if(deliveryLocation.garage[i] == null)
                {
                    deliveryLocation.garage[i] = vehicle;
                    index = i;
                    break;
                }
            }
            return index;

        }
        public int UnloadVehicle(int garageSlot)
        {
            if (this.garage[garageSlot].IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }//throwing exception > If garage full
            Vehicle vehicle = GetVehicle(garageSlot);
            int productsCount = 0;
            while (!vehicle.IsEmpty || this.IsFull)
            {
                this.products.Add(vehicle.Unload());
                productsCount++;
            }
            return productsCount;
        }
    }
}
