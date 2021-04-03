using System;

namespace fdghhh
{
    class Program
    {
        static void Main(string[] args)
        {
            int agentsCount = int.Parse(Console.ReadLine());
            
            decimal sum = 0;

            for (int agent = 0; agent < agentsCount; agent++)
            {
                int dealsCount = int.Parse(Console.ReadLine());
                for (int deal = 0; deal < dealsCount; deal++)
                {
                    int area = int.Parse(Console.ReadLine());
                    decimal pricePerM = decimal.Parse(Console.ReadLine());

                    decimal currentSum = area * pricePerM;
                    sum += currentSum;

                }

            }
            Console.WriteLine($"{sum/agentsCount:f3}");
        }
    }
}
