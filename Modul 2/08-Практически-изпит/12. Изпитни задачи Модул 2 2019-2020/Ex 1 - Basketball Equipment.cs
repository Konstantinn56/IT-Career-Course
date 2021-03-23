using System;

namespace asdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int basketballTrainingPrice = int.Parse(Console.ReadLine());

            double sum = 0;
            sum += basketballTrainingPrice;
            double basketShoes = basketballTrainingPrice - (basketballTrainingPrice * 40/100);
            double basketCloths = basketShoes - (basketShoes * 20/100);
            double basketballBall = basketCloths /4;
            double basketballAccsesoars = basketballBall /5;
            sum += basketballBall + basketShoes + basketCloths + basketballAccsesoars;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
