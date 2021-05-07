using System;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            

            int days = DateModifier.DiffrenceBetweenDates(date1, date2);
            Console.WriteLine(days);
        }
    }
}
