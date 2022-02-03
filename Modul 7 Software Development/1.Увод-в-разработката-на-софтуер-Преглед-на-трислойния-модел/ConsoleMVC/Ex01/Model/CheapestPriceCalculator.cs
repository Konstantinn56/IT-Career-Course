using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Model
{
    public class CheapestPriceCalculator
    {
        /// <summary>
        /// Количество км, което трябва да бъде изминато
        /// </summary>
        private double kmCount;

        public double KmCount
        {
            get { return kmCount; }
            set 
            { 
                //kmCount [1...5000]
                if(value >= 1 && value <= 5000)
                {
                    kmCount = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid input!");
                }
            }
        }

        /// <summary>
        /// Период от деня (ден || нощ)
        /// </summary>
        private string dayPeriod;

        public string DayPeriod
        {
            get { return dayPeriod; }
            set 
            {
                //dayPeriod = day||night
                if (value.ToLower().Equals("day") || value.ToLower().Equals("night"))
                {
                    dayPeriod = value.ToLower();
                }
                else
                {
                    throw new InvalidDataException("Invalid input!");
                }
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="km">Километри</param>
        /// <param name="period">Период на деня</param>
        public CheapestPriceCalculator(double km , string period)
        {
            this.KmCount = km;
            this.DayPeriod = period;
        }
        public CheapestPriceCalculator() : this(1, "day")
        {

        }
        /// <summary>
        /// Изчислява най-евтиния вариант за транспорт
        /// </summary>
        /// <returns>Цената за транспорта</returns>
        public double GetCheapestOption()
        {
            double finalPrice;
            if(this.KmCount < 20)
            {
                double startingPrice = 0.7;
                if (this.DayPeriod.Equals("day"))
                {
                    finalPrice = 0.79 * this.KmCount;
                }//day
                else
                {
                    finalPrice = 0.9 * this.KmCount;
                }//night
                finalPrice += startingPrice;
            }//km < 20 

            else if(this.KmCount >= 20 && this.KmCount < 100)
            {
                finalPrice = 0.09 * this.KmCount;
            }//km [20...99]

            else
            {
                finalPrice = 0.06 * this.KmCount;
            }//km>=100

            return finalPrice;
        }

    }
}
