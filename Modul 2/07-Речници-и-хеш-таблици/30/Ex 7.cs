using System;
using System.Collections.Generic;
using System.Linq;

namespace adffghh
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            //Country, <city,Population>
            Dictionary<string, Dictionary<string, int>> report = new Dictionary<string, Dictionary<string, int>>();

            while (!input[0].Equals("report"))
            {
                //Sofia|Bulgaria|1
                //Veliko Tarnovo| Bulgaria | 2
                string city = input[0];
                string country = input[1];
                int population = int.Parse(input[2]);
                if (!report.ContainsKey(country))
                {
                    report.Add(country, new Dictionary<string, int>());
                }
                if (!report[country].ContainsKey(city))
                {
                    report[country].Add(city,0);
                }
                report[country][city] += population;

                input = Console.ReadLine().Split('|');
            }
            foreach (var kvp in report.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{kvp.Key} (total population: {kvp.Value.Values.Sum()})");
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=> {item.Key}: {item.Value}");
                }
            }
        }
    }
}
