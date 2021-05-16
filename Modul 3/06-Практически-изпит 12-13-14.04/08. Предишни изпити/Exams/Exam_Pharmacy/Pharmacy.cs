using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_Pharmacy
{
    public class Pharmacy
    {
        private string name;
        private List<Medicine> medicines;

        public Pharmacy(string name)
        {
            this.Name = name;
            this.Medicines = new List<Medicine>();
        }

        ////////////////////////////////////////////////////////////////////////////////

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid name");
                }
                else
                    name = value;
            }
        }
        public List<Medicine> Medicines
        {
            get { return medicines; }
            private set { medicines = value; }
        }

        ////////////////////////////////////////////////////////////////////////////////

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Medicines.Count != 0)
            {

                sb.Append($"Pharmacy {this.Name} has {this.Medicines.Count} medicines and they are:");
                foreach (var med in this.Medicines)
                {
                    sb.AppendLine();
                    sb.Append($"Medicine: {med.Name} with price {med.Price:f2}");
                }
            }
            else
            {
                sb.AppendLine($"Pharmacy {this.Name} has 0 medicines and they are:");
                sb.Append($"N/A");
            }
            return sb.ToString();

        }

        ////////////////////////////////////////////////////////////////////////////////
        public void Order(Medicine medicine)
        {
            this.Medicines.Add(medicine);
        }
        public bool Sell(Medicine medicine)
        {
            return this.Medicines.Remove(medicine);
        }
        public double CalculateTotalPrice()
        {
            double result = 0;
            foreach (var m in this.Medicines)
            {
                result += m.Price;
            }
            return result;
        }
        public void RenamePharmacy(string newName)
        {
            this.Name = newName;
        }
        public void SellAllMedicines()
        {
            this.Medicines.RemoveRange(0, this.Medicines.Count);
        }
        public Medicine GetMedicineWithHighestPrice()
        {
            return this.Medicines.OrderByDescending(p => p.Price).FirstOrDefault();
        }

        public Medicine GetMedicineWithLowestPrice()
        {
            return this.Medicines.OrderBy(p => p.Price).FirstOrDefault();
        }
    }
}

