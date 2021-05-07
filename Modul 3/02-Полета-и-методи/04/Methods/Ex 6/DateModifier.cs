using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_6
{
    static class DateModifier
    {
        static public int DiffrenceBetweenDates(string date1, string date2)
        {
            DateTime firstDate = DateTime.Parse(date1);
            DateTime secondDate = DateTime.Parse(date2);

            int days = Math.Abs((firstDate - secondDate).Days);
            return days;
        }
    }
}
