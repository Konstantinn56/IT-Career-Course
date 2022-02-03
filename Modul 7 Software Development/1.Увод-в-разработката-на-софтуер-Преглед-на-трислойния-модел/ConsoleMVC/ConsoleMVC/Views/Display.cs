using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Views
{
    internal class Display
    {
        /// <summary>
        /// Процент на бакшиша
        /// </summary>
        public double Percent { get; set; }

        /// <summary>
        /// Сума на сметката
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Обща сума = Сум на сметка + Бакшиш
        /// </summary>
        public double Total { get; set; }

        /// <summary>
        /// Стойност на бакшиша
        /// </summary>
        public double TipAmount { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Display()
        {
            this.Amount = 0;
            this.Percent = 0;
            this.TipAmount = 0;
            this.Total = 0;
            GetValues();
        }

        /// <summary>
        /// Въвеждане на сума и процент
        /// </summary>
        public void GetValues()
        {
            Console.Write("Enter the amount of the meal: ");
            this.Amount = double.Parse(Console.ReadLine());
            Console.Write("Enter the percent you want to tip: ");
            this.Percent = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Показва бакшиша и общата сметка
        /// </summary>
        public void ShowTipAndTotal()
        {
            Console.WriteLine("Your tip is: {0}$", this.TipAmount);
            Console.WriteLine("The total will be {0}$", this.Total);
        }
    }

    
}
