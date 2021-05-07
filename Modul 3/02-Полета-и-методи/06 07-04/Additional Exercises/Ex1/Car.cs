using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class Car
    {
        private string model;
        private double fuel;
        private double fuelCostPerKm;
        private int travelledDistance = 0;

        public Car(string model, double fuel, double fuelCostPerKm)
        {
            this.model = model;
            this.Fuel = fuel;
            this.FuelCostPerKm = fuelCostPerKm;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
        public double FuelCostPerKm
        {
            get { return fuelCostPerKm; }
            set { fuelCostPerKm = value; }
        }
        public int TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }

        public void CarDrive(int km)
        {
            double fuelCostForThisKm = km * this.FuelCostPerKm;
            if(this.Fuel > fuelCostForThisKm)
            {
                this.Fuel -= fuelCostForThisKm;
                this.TravelledDistance += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public override string ToString()
        {
            return $"{model} {fuel:f2} {travelledDistance}";
        }
    }
}
