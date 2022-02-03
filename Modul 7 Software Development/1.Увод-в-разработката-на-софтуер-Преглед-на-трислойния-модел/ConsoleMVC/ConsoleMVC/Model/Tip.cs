namespace ConsoleMVC.Model
{
    /// <summary>
    /// Бакшиш
    /// </summary>
    internal class Tip
    {
        /// <summary>
        /// Стойност
        /// </summary>
        private double amount;

        /// <summary>
        /// Процент
        /// </summary>
        private double percent;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="amount">Сума</param>
        /// <param name="percent">Процент</param>
        public Tip(double amount, double percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }
        /// <summary>
        /// Конструктор по подразбиране
        /// </summary>
        public Tip() : this(0,0)
        {
            //By default
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public double Percent
        {
            get { return percent; }
            set 
            { 
                if(value > 1)
                {
                    this.percent = value / 100;
                }
                else
                {
                    this.percent = value;
                } 
            }
        }
        /// <summary>
        /// Смята сумата на бакшиша
        /// </summary>
        /// <returns>Сума * Процент</returns>
        public double CalculateTip()
        {
            return this.Amount * this.Percent;
        }

        /// <summary>
        /// Смята общата сума
        /// </summary>
        /// <returns>Сума + бакшиша</returns>
        public double CalculateTotal()
        {
            return CalculateTip() + this.Amount;
        }
    }
}
