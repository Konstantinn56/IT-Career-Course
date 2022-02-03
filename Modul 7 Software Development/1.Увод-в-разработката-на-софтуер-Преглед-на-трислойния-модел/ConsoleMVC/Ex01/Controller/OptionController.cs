using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Controller
{
    using Ex01.View;
    using Ex01.Model;

    public class OptionController
    {
        private CheapestPriceCalculator cpc;
        private Display d;

        public OptionController()
        {
            d = new Display();
            cpc = new CheapestPriceCalculator(d.KmCount,d.DayPeriod);

            d.CheapestOption = cpc.GetCheapestOption();
            d.GetCheapestPrice();
        }
    }
}
