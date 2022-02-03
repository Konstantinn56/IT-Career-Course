using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.View
{
    public class Display
    {
        /// <summary>
        /// Кол Километри
        /// </summary>
        public double KmCount { get; set; }

        /// <summary>
        /// Период на деня
        /// </summary>
        public string DayPeriod { get; set; }

        public double CheapestOption { get; set; }

        public Display()
        {
            this.KmCount = 0;
            this.DayPeriod = "day";
            GetValues();
        }

        private void GetValues()
        {
            Console.Write("Enter the number of km: ");
            this.KmCount = double.Parse(Console.ReadLine());
            Console.Write("Enter the period of the day: ");
            this.DayPeriod = Console.ReadLine();
        }

        public void GetCheapestPrice()
        {
            Console.WriteLine($"The price of the cheapest transport is: {Math.Round(this.CheapestOption,2)}");
        }
    }
}
